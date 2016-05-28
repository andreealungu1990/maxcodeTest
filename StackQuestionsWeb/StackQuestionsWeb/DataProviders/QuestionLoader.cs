using StackQuestionsWeb.Constants;
using StackQuestionsWeb.Models;
using StackQuestionsWeb.WebHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StackQuestionsWeb.DataProviders
{
    public class QuestionsLoader : IQuestionsLoader
    {
        private readonly IHttpClient httpClient;
        public QuestionsLoader(IHttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<RootObject> GetQuestions(string text, string tag, int pageNumber)
        {
            var url = string.IsNullOrEmpty(text) && string.IsNullOrEmpty(tag) ? StackexchangeApi.DefaultUrl : StackexchangeApi.Url;
            var queryParams = new {
                order = StackexchangeApi.Order, 
                sort = StackexchangeApi.Sort,
                tagged = tag,
                intitle = text,
                pagesize = StackexchangeApi.PageSize,
                page = pageNumber,
                site = StackexchangeApi.Site, 
                filter = StackexchangeApi.Filter 
            };

            return await httpClient.Get<RootObject>(url, queryParams);            
        }
    }
}