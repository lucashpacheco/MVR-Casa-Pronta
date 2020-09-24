using System.Web;
using System.Web.Optimization;

namespace MVR_Casa_Pronta
{
    public class BundleConfig
    {
        // Para obter mais informações sobre o agrupamento, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // pronto para a produção, utilize a ferramenta de build em https://modernizr.com para escolher somente os testes que precisa.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr.custom.70736.js",
                        "~/Scripts/modernizr-*"));
            
            bundles.Add(new ScriptBundle("~/bundles/gama").Include(
                        "~/Scripts/gamma",
                        "~/Scripts/jquery.history.js",
                        "~/Scripts/jquery.masonry.min.js",
                        "~/Scripts/jquerypp.custom.js",
                        "~/Scripts/js-url.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",                    
                      "~/Content/site.css"));
            
            bundles.Add(new StyleBundle("~/Content/gama").Include(
                      "~/Content/demo.css",
                      "~/Content/noJS.css",
                      "~/Content/style.css"));
        }
    }
}
