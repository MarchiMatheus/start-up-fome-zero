using System.Web;
using System.Web.Optimization;

namespace FomeZero
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Global/jquery-{version}.js",
                        "~/Scripts/Global/jquery-ui.js",
                        "~/Scripts/Global/FomeZeroUtil.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Global/jquery.validate*"));

            // Use a versão em desenvolvimento do Modernizr para desenvolver e aprender. Em seguida, quando estiver
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Global/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Global/bootstrap.js",
                      "~/Scripts/Global/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/Content/site.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/bootstrap-override.css"));

            #region [ Cardápio ]

            bundles.Add(new ScriptBundle("~/Areas/Cardapio").Include(
                        "~/Scripts/Areas/Cardapio/Cardapio.js"));

            #endregion

            #region [ Lanche personalizado ]

            bundles.Add(new ScriptBundle("~/Areas/LanchePersonalizado").Include(
                        "~/Scripts/Areas/LanchePersonalizado/LanchePersonalizado.js"));

            #endregion
        }
    }
}
