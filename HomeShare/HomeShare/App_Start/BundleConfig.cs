using System.Web;
using System.Web.Optimization;

namespace HomeShare
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/js/script.js",
                      "~/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.css",
                      "~/css/style.css"));

            //< !--Owl stylesheet-- >
            bundles.Add(new StyleBundle("~/Content/owl").Include(
                   "~/assets/owl-carousel/owl.carousel.css",
                   "~/assets/owl-carousel/owl.theme.css"
                   ));

            bundles.Add(new ScriptBundle("~/Content/owlJS").Include(
                  "~/assets/owl-carousel/owl.carousel.js"
                  ));
            //< !--Owl stylesheet-- >

            //< !--slitslider-- >
            bundles.Add(new StyleBundle("~/Content/slitslider").Include(
                   "~/assets/slitslider/css/style.css",
                   "~/assets/slitslider/css/custom.css"
                   ));
            bundles.Add(new ScriptBundle("~/Content/slitsliderJS").Include(
                  "~/assets/slitslider/js/modernizr.custom.79639.js",
                  "~/assets/slitslider/js/jquery.ba-cond.min.js",
                  "~/assets/slitslider/js/jquery.slitslider.js"
                  ));
            //< !--slitslider-- >


        }
    }
}
