using System;
using System.Reflection;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Http;
using System.Web.Mvc;

namespace StackQuestionsWeb.App_Start
{
    public static class AutofacConfig
    {
        private static readonly Lazy<IContainer> Container = new Lazy<IContainer>(() =>
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            return builder.Build();
        });

        public static IContainer GetContainer()
        {
            return Container.Value;
        }

        public static void Register()
        {
            var container = GetContainer();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}