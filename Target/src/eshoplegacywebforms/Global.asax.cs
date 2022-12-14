using eShopLegacyWebForms.Models.Infrastructure;
using System;
using System.Data.Entity;
using System.IO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace eShopLegacyWebForms
{

   [Observable]
   public class Global : Stub._System.Web.HttpApplication
   {


       protected void Application_Start(object sender, EventArgs e)
       {
           // Code that runs on application startup
           BundleConfig.RegisterBundles(Stub._System.Web.Optimization.BundleTable.Bundles);
           Database.SetInitializer(new CatalogDBInitializer());
       }

   }
}