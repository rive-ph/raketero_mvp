using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Services.Concrete
{
    public abstract class RepositoryBase
    {

    }

    public abstract class RestRepositoryBase : RepositoryBase
    {

        protected RestClient Client { get; set; }
        public string Url { get; }
        public string ApiKey { get; }

        public RestRepositoryBase(string url, string apiKey)
        {
            Client = new RestClient(url);
            Url = url;
            ApiKey = apiKey;
        }

        protected IRestRequest CreateRequest()
        { 
            var request = new RestRequest(Url,DataFormat.Json);
            request.AddParameter("key", ApiKey);
            return request;
        }

    }
}
