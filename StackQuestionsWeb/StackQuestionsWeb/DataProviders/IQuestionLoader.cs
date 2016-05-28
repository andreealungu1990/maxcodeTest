using StackQuestionsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackQuestionsWeb.DataProviders
{
    public interface IQuestionsLoader
    {
        RootObject GetQuestions();
    }
}