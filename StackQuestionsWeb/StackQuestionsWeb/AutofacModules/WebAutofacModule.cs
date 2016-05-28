using Autofac;
using StackQuestionsWeb.DataProviders;
using StackQuestionsWeb.WebHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StackQuestionsWeb.AutofacModules
{
    public class WebAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HttpClientHelper>().As<IHttpClient>().SingleInstance();
            builder.RegisterType<QuestionsLoader>().As<IQuestionsLoader>().SingleInstance();
        }
    }
}