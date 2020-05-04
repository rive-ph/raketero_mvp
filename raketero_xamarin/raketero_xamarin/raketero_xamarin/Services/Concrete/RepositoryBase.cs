using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Services.Concrete
{
    public interface IRepository { }
    public abstract class RepositoryBase : IRepository { }

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

        protected IRestRequest CreateRequest(string type)
        { 
            var request = new RestRequest(Url,DataFormat.Json);
            request.AddParameter("key", ApiKey);
            request.AddParameter("type", type);
            return request;
        }

        protected IRestRequest CreateRequest(string type,string action)
        {
            var request = new RestRequest(Url, DataFormat.Json);
            request.AddParameter("key", ApiKey);
            request.AddParameter("type", type);
            request.AddParameter("action", action);
            return request;
        }

    }
}
