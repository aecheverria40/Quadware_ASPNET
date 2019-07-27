using System.Web;
using System.Web.Optimization;

namespace Quadware_Project
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"));

            //Bootstrap Material Design
            bundles.Add(new StyleBundle("~/Content/materialize").Include(
                "~/Content/bootstrap-material-design/css/bootstrap-material-design.min.css"));

            bundles.Add(new ScriptBundle("~/bundle/materializejs").Include(
                "~/Content/bootstrap-material-design/js/bootstrap-material-design.js"));

            bundles.Add(new StyleBundle("~/Content/navbar-fixed").Include(
                "~/Content/bootstrap-material-design/navbar-top-fixed.css"
                ));

            bundles.Add(new ScriptBundle("~/bundle/popperjs").Include(
                "~/Scripts/umd/popper.js"));

            bundles.Add(new ScriptBundle("~/bundle/popperjsutils").Include(
                "~/Scripts/umd/popper-utils.js"));
        }
    }
}
