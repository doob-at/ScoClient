using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using doob.Reflectensions.Common;
using doob.ScoClient.Helper;
using doob.ScoClient.Models;
using Flurl;
using Flurl.Http;


namespace doob.ScoClient
{
    public class SCOClient
    {
        public ClientOptions Options { get; }
        public SCOClient(string baseUrl)
        {
            Options = new ClientOptionsBuilder().WithBaseUrl(baseUrl);
        }

        public SCOClient(string baseUrl, Action<ClientOptionsBuilder> options)
        {
            var opts = new ClientOptions();
            opts.BaseUrl = baseUrl;
            Options = options.InvokeAction(new ClientOptionsBuilder(opts));
        }

        private IFlurlRequest GetBaseUrl()
        {

            
            var cl = new FlurlClient().Configure(settings =>
            {
                if (Options.UseDefaultCredentials)
                {
                    settings.HttpClientFactory = new SCOHttpClientFactory();
                }
            });


            var url = new Url(Options.BaseUrl).WithClient(cl).AppendPathSegments("Orchestrator2012", "Orchestrator.svc").AllowAnyHttpStatus();

            if (Options.Credential != null)
            {
                url = url.WithBasicAuth($"{Options.Credential.Domain}\\{Options.Credential.UserName}".Trim('\\'), Options.Credential.Password);
            }
            
            return url;
        }

        public Task<Runbook> GetRunbookById(string id)
        {
            return GetRunbookById(id.ToGuid());
        }
        public async Task<Runbook> GetRunbookById(Guid id)
        {
            var url = GetBaseUrl().AppendPathSegment($"Runbooks(guid'{id}')");

            var result = await url.GetStringAsync();

            var xml = SimpleXml.Parse(result);

            var rb = Runbook.FromXml(xml);

            var parameters = await GetRunbookParameters(id);

            rb.InputParameters = parameters?
                .Where(p => p.Direction.Equals("IN", StringComparison.CurrentCultureIgnoreCase)).ToList() ?? new List<Parameter>();
            rb.OutputParameters = parameters?
                .Where(p => p.Direction.Equals("OUT", StringComparison.CurrentCultureIgnoreCase)).ToList() ?? new List<Parameter>();

            return rb;
        }
        
        public async Task<Runbook> GetRunbookByPath(string path)
        {
            var url = GetBaseUrl().AppendPathSegment($"Runbooks")
                .SetQueryParam("$filter",$"Path eq '{path}'");
            var result = await url.GetStringAsync();

            var xml = SimpleXml.Parse(result);

            var rb = Runbook.FromXml(xml);

            var parameters = await GetRunbookParameters(rb);

            rb.InputParameters = parameters?
                .Where(p => p.Direction.Equals("IN", StringComparison.CurrentCultureIgnoreCase)).ToList() ?? new List<Parameter>();
            rb.OutputParameters = parameters?
                .Where(p => p.Direction.Equals("OUT", StringComparison.CurrentCultureIgnoreCase)).ToList() ?? new List<Parameter>();

            return rb;
        }
        
        public Task<List<Parameter>> GetRunbookParameters(Runbook rb)
        {
            return GetRunbookParameters(rb.Id);
        }
        public async Task<List<Parameter>> GetRunbookParameters(Guid id)
        {
            var url = GetBaseUrl().AppendPathSegment($"Runbooks(guid'{id}')//Parameters");

            var result = await url.GetStringAsync();

            var xml = SimpleXml.Parse(result);

            return Parameter.FromXml(xml);
        }

        public Task<List<Runbook>> GetRunbooks()
        {
            return GetRunbooks(null);
        }
        public async Task<List<Runbook>> GetRunbooks(string filter)
        {
            var url = GetBaseUrl().AppendPathSegment($"Runbooks");

            if (!String.IsNullOrWhiteSpace(filter))
            {
                url = url.SetQueryParam("$filter", filter);
            }

            var result = await url.GetStringAsync();

            var xml = SimpleXml.Parse(result);
            xml.AddNameSpace("x", "http://www.w3.org/2005/Atom");

            var rbs = xml.SelectElements("//x:entry").Select(e =>
           {
               var exml = e.ToSimpleXml();
               return Runbook.FromXml(exml);
           }).ToList();

            foreach (var runbook in rbs)
            {

                var parameters = await GetRunbookParameters(runbook.Id);

                runbook.InputParameters = parameters?
                    .Where(p => p.Direction.Equals("IN", StringComparison.CurrentCultureIgnoreCase)).ToList() ?? new List<Parameter>();
                runbook.OutputParameters = parameters?
                    .Where(p => p.Direction.Equals("OUT", StringComparison.CurrentCultureIgnoreCase)).ToList() ?? new List<Parameter>();
            }

            return rbs;
        }

        public async Task<List<Runbook>> GetRunbooksByName(string name)
        {
            var url = GetBaseUrl().AppendPathSegment($"Runbooks")
                .SetQueryParam("$filter",$"Name eq '{name}'");

            var result = await url.GetStringAsync();

            var xml = SimpleXml.Parse(result);
            xml.AddNameSpace("x", "http://www.w3.org/2005/Atom");

            var rbs = xml.SelectElements("//x:entry").Select(e =>
            {
                var exml = e.ToSimpleXml();
                return Runbook.FromXml(exml);
            }).ToList();

            foreach (var runbook in rbs)
            {

                var parameters = await GetRunbookParameters(runbook.Id);

                runbook.InputParameters = parameters?
                    .Where(p => p.Direction.Equals("IN", StringComparison.CurrentCultureIgnoreCase)).ToList() ?? new List<Parameter>();
                runbook.OutputParameters = parameters?
                    .Where(p => p.Direction.Equals("OUT", StringComparison.CurrentCultureIgnoreCase)).ToList() ?? new List<Parameter>();
            }

            return rbs;
        }


        public Task StartRunbook(Runbook rb)
        {
            return StartRunbook(rb, new Dictionary<string, object>());
        }
        public async Task StartRunbook(Runbook rb, Dictionary<string, object> inputParameters)
        {
            var startRunbookRequest = new StartRunbookRequest();
            startRunbookRequest.RunbookId = rb.Id.ToString();

            startRunbookRequest.Parameters = BuildRequestParameters(rb, inputParameters);

            var template = GetFromResources("StartRunbook.xml");

            var xmlString = TemplateParser.Parse(template, startRunbookRequest);
            var xml = new SimpleXml(xmlString);

            var url = GetBaseUrl().AppendPathSegment($"Jobs")
                .WithHeader("User-Agent", "Microsoft ADO.NET Data Services")
                .WithHeader("Content-Type","application/atom+xml")
                .WithHeader("Accept","application/atom+xml,application/xml")
                .WithHeader("Accept-Encoding","identity")
                .WithHeader("Accept-Language","en-US")
                .WithHeader("DataServiceVersion","1.0;NetFx")
                .WithHeader("MaxDataServiceVersion","2.0;NetFx")
                .WithHeader("Pragma","no-cache");

            
            var result = await url.PostStringAsync(xml.ToString());
            var str = await result.GetStringAsync();
        }

        private List<StartRunbookParameter> BuildRequestParameters(Runbook rb, Dictionary<string, object> parameters)
        {
            var dic = new List<StartRunbookParameter>();

            foreach (var pair in parameters)
            {


                Parameter rbParameter = null;
                if (pair.Key.IsGuid())
                {
                    rbParameter = rb.InputParameters.Single(p => p.Id == pair.Key.ToGuid());
                }
                else
                {
                    rbParameter = rb.InputParameters.FirstOrDefault(p => p.Name == pair.Key);
                    if (rbParameter == null)
                    {
                        rbParameter = rb.InputParameters.First(p => p.Name.Equals(pair.Key, StringComparison.CurrentCultureIgnoreCase));
                    }
                }

                
                var srp = new StartRunbookParameter();
                srp.Id = rbParameter.Id.ToString();

                srp.Value = NormalizeParameterValue(rbParameter, pair.Value);
                dic.Add(srp);
            }

            return dic;
        }

        private string NormalizeParameterValue(Parameter parameter, object value)
        {
            switch (parameter.Type.ToLower())
            {
                case "string":
                {
                    return value.ToString();
                }
                case "integer":
                {
                    if (value is int integer)
                    {
                        return integer.ToString();
                    }

                    if (value is string str)
                    {
                        if (str.IsInt())
                            return str;
                    }

                    throw new Exception($"Parameter '{parameter.Name}' has to be an 'integer', but it is of Type '{value.GetType().Name}'.");
                }
                case "boolean":
                {
                    if (value is bool boolean)
                    {
                        return boolean.ToString();
                    }

                    if (value is string str)
                    {
                        return str.ToBoolean().ToString();
                    }

                    if (value is int integer)
                    {
                        return (integer != 0).ToString();
                    }

                    return false.ToString();
                }
                case "datetime":
                {
                    if (value is DateTime dateTime)
                    {
                        return dateTime.ToString();
                    }

                    return value.ToString().ToDateTime().ToString();
                }
            }

            return value.ToString();
        }

        private string GetFromResources(string resourceName)
        {
            using (Stream stream = this.GetType().Assembly.GetManifestResourceStream($"ScoClient.Templates.{resourceName}"))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }

            }
        }
    }
}
