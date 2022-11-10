using eShopLegacyWebForms.Models.Infrastructure;
using System;
using System.Data.Entity;
using System.IO;
using System.Web;
using System.Web.Optimization;

namespace eShopLegacyWebForms
{
    public class Global : HttpApplication
    {
        

        protected void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer(new CatalogDBInitializer());
        }
    }
}