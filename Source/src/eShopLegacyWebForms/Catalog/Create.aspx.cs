using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace eShopLegacyWebForms.Catalog
{
    public partial class Create : Page
    {
        public ICatalogService CatalogService;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogService = new CatalogService();          
            Brand.DataSource = CatalogService.GetCatalogBrands();
            Type.DataSource = CatalogService.GetCatalogTypes();
            Brand.DataBind();
            Type.DataBind();
        }

        protected void Create_Click(object sender, EventArgs e)
        {
            if (this.ModelState.IsValid)
            {
                var catalogItem = new CatalogItem
                {
                    Name = txt_Name.Text,
                    Description = Description.Text,
                    CatalogBrandId = int.Parse(Brand.SelectedValue),
                    CatalogTypeId = int.Parse(Type.SelectedValue),
                    Price = decimal.Parse(Price.Text),
                    AvailableStock = int.Parse(Stock.Text),
                    RestockThreshold = int.Parse(Restock.Text),
                    MaxStockThreshold = int.Parse(Maxstock.Text)
                };

                CatalogService.CreateCatalogItem(catalogItem);
                CatalogService.Dispose();
                Response.Redirect("~/Home.aspx");
            }
        }
    }
}