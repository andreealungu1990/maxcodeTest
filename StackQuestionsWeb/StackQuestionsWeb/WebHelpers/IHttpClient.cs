using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StackQuestionsWeb.WebHelpers
{
    public interface IHttpClient
    {
        Task<T> Get<T>(string url, object queryParams);
    }
}