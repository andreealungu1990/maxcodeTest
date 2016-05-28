using StackQuestionsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StackQuestionsWeb.DataProviders
{
    public interface IQuestionsLoader
    {
        Task<RootObject> GetQuestions(string text, string tag, int pageNumber);
    }
}