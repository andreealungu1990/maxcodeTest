using Flurl;
using Flurl.Http.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace StackQuestionsWeb.WebHelpers
{
    public class CustomHttpClientFactory : DefaultHttpClientFactory
    {
        public override HttpClient CreateClient(Url url, HttpMessageHandler handler)
        {
            var httpClientHandler = handler as HttpClientHandler;

            if (httpClientHandler == null)
                return null;

            httpClientHandler.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            var httpClient = base.CreateClient(url, handler);
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            return httpClient;
        }
    }
}