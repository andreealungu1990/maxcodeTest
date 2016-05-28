using StackQuestionsWeb.Models;
using StackQuestionsWeb.WebHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public RootObject GetQuestions()
        {
            var url = @"https://api.stackexchange.com/2.2/questions";
            var queryParams = new { order = "desc", sort = "votes", site = "stackoverflow", filter = "!FsaoAlyDgQYKf.29A3mLybMzWt" };
            return  httpClient.Get<RootObject>(url, queryParams).Result;            
        }
    }
}