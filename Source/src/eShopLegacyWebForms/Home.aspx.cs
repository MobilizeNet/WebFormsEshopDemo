using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using eShopLegacyWebForms.ViewModel;
using System;
using System.IO;
using System.Web.UI;

namespace eShopLegacyWebForms
{
    public partial class Home : Page
    {
        public ICatalogService CatalogService;

        protected CatalogItemsViewModel<CatalogItem> Model { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            CatalogService = new CatalogService();
            Model = CatalogService.GetCatalogItems();
            productList.DataSource = Model.Data;
            productList.DataBind();
            CatalogService.Dispose();
        }

        protected void productList_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            productList.PageIndex = e.NewPageIndex;
            productList.DataBind();
        }
    }
}