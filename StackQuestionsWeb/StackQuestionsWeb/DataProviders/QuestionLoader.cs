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

        public async Task<RootObject> GetQuestions()
        {
            var queryParams = new {
                order = StackexchangeApi.Order, 
                sort = StackexchangeApi.Sort,
                site = StackexchangeApi.Site, 
                filter = StackexchangeApi.Filter 
            };

            return await httpClient.Get<RootObject>(StackexchangeApi.Url, queryParams);            
        }
    }
}