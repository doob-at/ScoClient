using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SCO
{
    public class ClientOptions
    {
        public string BaseUrl { get; internal set; }
        public NetworkCredential Credential { get; internal set; }
        public bool UseDefaultCredentials { get; internal set; }
        
    }

    public class ClientOptionsBuilder
    {
        private ClientOptions options = new ClientOptions();

        public ClientOptionsBuilder(ClientOptions clientOptions)
        {
            options = clientOptions;
        }

        public ClientOptionsBuilder()
        {
            
        }


        public ClientOptionsBuilder WithBaseUrl(string baseUrl)
        {
            options.BaseUrl = baseUrl;
            return this;
        }

        public ClientOptionsBuilder WithCredential(string username, string password)
        {
            options.Credential = new NetworkCredential(username, password);
            return this;
        }

        public ClientOptionsBuilder WithCredential(NetworkCredential networkCredential)
        {
            options.Credential = networkCredential;
            return this;
        }

        public ClientOptionsBuilder WithDefaultCredential(bool value = true)
        {
            options.UseDefaultCredentials = value;
            return this;
        }

        public static implicit operator ClientOptions(ClientOptionsBuilder builder)
        {
            return builder.options;
        }
    }
    
}
