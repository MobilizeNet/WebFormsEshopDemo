using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using eShopLegacyWebForms.ViewModel;
using System;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms
{

   [Observable]
   public partial class Home : Mobilize.Web.UI.Controls.Page
   {

      [Intercepted]
      public ICatalogService CatalogService { get; set; }

      [Intercepted]

      protected CatalogItemsViewModel<CatalogItem> Model { get; set; }

      protected void Page_Load(object sender, EventArgs e)
      {
          CatalogService = new CatalogService();
          Model = CatalogService.GetCatalogItems();
          productList.DataSource = Model.Data;
          productList.DataBind();
          CatalogService.Dispose();
      }

      protected void productList_PageIndexChanging(object sender, Mobilize.Web.UI.Controls.GridViewPageEventArgs e)
      {
          productList.PageIndex = e.NewPageIndex;
          productList.DataBind();
      }

   }
}