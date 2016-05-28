using PagedList;
using StackQuestionsWeb.DataProviders;
using StackQuestionsWeb.Models;
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

        public ActionResult Index(string text, string tag, int? pageNumber)
        {
            var pageIndex = pageNumber ?? 1;
            var result = Task.Run(() => questionsLoader.GetQuestions()).Result;

            var itemsPagedList = new StaticPagedList<Item>(result.Items, pageIndex, 20, result.Total / 20);

            return View(itemsPagedList);
        }

    }
}
