using System;
using System.Collections.Generic;
using System.Linq;
using doob.Reflectensions;
using Newtonsoft.Json.Linq;
using Scriban.Runtime;

namespace doob.ScoClient
{
    public static class TemplateParser
    {
        public static string Parse(string template, object data)
        {
            return Parse(template, new List<object> {data});
        }

        public static string Parse(string template, params object[] data)
        {
            return Parse(template, data.ToList());
        }
        //public string Parse(string template, object[] data)
        //{
        //    return Parse(template, data.ToList());
        //}

        private static string Parse(string template, IEnumerable<object> data)
        {
            JObject jobject = new JObject();
            data.Aggregate(jobject, (a, b) => {
                var json = Json.Converter.ToJson(b);
                var jo = Json.Converter.ToJObject(json);
                return Json.Converter.Merge(a, jo);
            });

            var dict = Json.Converter.ToDictionary(jobject);

            return ParseScriptObject(template, dict);
        }

        private static string ParseScriptObject(string template, Dictionary<string, object> data)
        {
            var scriptObj = new ScriptObject(StringComparer.OrdinalIgnoreCase);
            scriptObj.Import(data, renamer: member => member.Name);
            var scribanTemplate = Scriban.Template.Parse(template);
            return scribanTemplate.Render(scriptObj);
        }
    }
}
