using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace eShopLegacyWebForms
{

   [Observable]
   public class BundleConfig
   {
       // For more information on Bundling, visit https://go.microsoft.com/fwlink/?LinkID=303951
       public static void RegisterBundles(Stub._System.Web.Optimization.BundleCollection bundles)
      {
          bundles.Add(new Stub._System.Web.Optimization.ScriptBundle("~/bundles/WebFormsJs").Include(
                          "~/Scripts/WebForms/WebForms.js",
                          "~/Scripts/WebForms/WebUIValidation.js",
                          "~/Scripts/WebForms/MenuStandards.js",
                          "~/Scripts/WebForms/Focus.js",
                          "~/Scripts/WebForms/GridView.js",
                          "~/Scripts/WebForms/DetailsView.js",
                          "~/Scripts/WebForms/TreeView.js",
                          "~/Scripts/WebForms/WebParts.js"));

          // Order is very important for these files to work, they have explicit dependencies
          bundles.Add(new Stub._System.Web.Optimization.ScriptBundle("~/bundles/MsAjaxJs").Include(
                  "~/Scripts/WebForms/MsAjax/MicrosoftAjax.js",
                  "~/Scripts/WebForms/MsAjax/MicrosoftAjaxApplicationServices.js",
                  "~/Scripts/WebForms/MsAjax/MicrosoftAjaxTimer.js",
                  "~/Scripts/WebForms/MsAjax/MicrosoftAjaxWebForms.js"));

          // Use the Development version of Modernizr to develop with and learn from. Then, when you’re
          // ready for production, use the build tool at https://modernizr.com to pick only the tests you need
          bundles.Add(new Stub._System.Web.Optimization.ScriptBundle("~/bundles/modernizr").Include(
                          "~/Scripts/modernizr-*"));

          bundles.Add(new Stub._System.Web.Optimization.StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/custom.css",
                    "~/Content/base.css",
                    "~/Content/site.css"));
         Stub._System.Web.UI.ScriptManager.ScriptResourceMapping.AddDefinition(
            "respond",
            new Stub._System.Web.UI.ScriptResourceDefinition
            {
                Path = "~/Scripts/respond.min.js",
                DebugPath = "~/Scripts/respond.js",
            });
      }

   }
}