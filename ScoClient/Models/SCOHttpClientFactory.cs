using System.Net.Http;
using Flurl.Http.Configuration;

namespace doob.ScoClient.Models
{
    public class SCOHttpClientFactory: DefaultHttpClientFactory
    {
        public override HttpMessageHandler CreateMessageHandler()
        {
            return new HttpClientHandler { UseDefaultCredentials = true };
        }
    }
}
