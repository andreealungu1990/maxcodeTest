using StackQuestionsWeb.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace StackQuestionsWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuestionsLoader questionsLoader;
        public HomeController(IQuestionsLoader questionsLoader)
        {
            this.questionsLoader = questionsLoader;
        }

        public ActionResult Index()
        {
            var result = Task.Run(() => questionsLoader.GetQuestions()).Result;
            return View();
        }

    }
}
