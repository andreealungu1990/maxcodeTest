using System.Web;
using System.Web.Optimization;

namespace StackQuestionsWeb
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js")
                             .Include("~/Scripts/jquery-1.7.1.js")
                             .Include("~/Scripts/jquery-ui-1.8.20.js")
                             .Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/css")
                          .Include("~/Content/bootstrap.css")
                          .Include("~/Content/bootstrap-responsive.css"));
        }
    }
}