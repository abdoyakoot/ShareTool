using System.Web;
using System.Web.Optimization;

namespace ShareTool
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            /*
            // First Way
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
            */
            // Second Way 
            ScriptBundle scriptBundle = new ScriptBundle("~/bundles/bootstrap"); //الاسم اللي هنده عليه في ال فيو
            scriptBundle.Include("~/Scripts/bootstrap.js"); // مسار الفايل اللي عاوز اضيفه ل الحزمه
            bundles.Add(scriptBundle); // اضافه هذا الكائن اللي قومت ب بنائه يدويا الي الحزمه

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true; // هذا الكود يقوم ب اتاحه التجميع والتصغير وهذا يجعل الصفحه اسرع واسلس
        }
    }
}
