using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using System.Collections;

namespace StackQuestionsWeb.WebHelpers
{
    public class HttpClientHelper:IHttpClient
    {
        public async Task<T> Get<T>(string url, object queryParams = null)
        {
            try
            {
                return await url
                    .SetQueryParams(queryParams)
                    .GetJsonAsync<T>();
            }
            catch (FlurlHttpTimeoutException)
            {
                Console.WriteLine("Timed out!");
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response != null)
                    Console.WriteLine("Failed with response code " + ex.Call.Response.StatusCode);
                else
                    Console.WriteLine("Totally failed before getting a response! " + ex.Message);
            }
            return GetDefaultResponseValue<T>();
        }

        private static T GetDefaultResponseValue<T>()
        {
            var type = typeof(T);
            var isTypeList = type.IsGenericType  && type.GetGenericTypeDefinition() == typeof(IList<>);
            if (isTypeList)
            {
                try
                {
                    return GetEmptyListForGenericListType<T>();
                }
                catch (Exception)
                {
                    return default(T);
                }
            }

            return default(T);
        }

        private static T GetEmptyListForGenericListType<T>()
        {
            var type = typeof(T);
            var myListElementType = type.GetGenericArguments().Single();

            var listType = typeof(List<>);
            var constructedListType = listType.MakeGenericType(myListElementType);

            var instance = Activator.CreateInstance(constructedListType);

            return (T)instance;
        }  
    }
}