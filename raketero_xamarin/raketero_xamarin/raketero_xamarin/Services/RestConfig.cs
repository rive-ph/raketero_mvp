using System;
using System.Collections.Generic;
using System.Text;

namespace raketero_xamarin.Services
{
    public interface IRestConfig
    {
        string BaseUrl { get; set; }
        string ApiKey { get; set; }
    }
    public class RestConfig : IRestConfig
    {
        public RestConfig(string baseUrl, string apiKey)
        {
            BaseUrl = baseUrl;
            ApiKey = apiKey;
        }
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
    }
}
