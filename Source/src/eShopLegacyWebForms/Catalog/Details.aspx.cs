using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using System.Web.UI;

namespace eShopLegacyWebForms.Catalog
{
    public partial class Details : Page
    {
        

        protected CatalogItem product;

        public ICatalogService CatalogService;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogService = new CatalogService();
            var productId = Convert.ToInt32(Request.QueryString["Id"]);
            product = CatalogService.FindCatalogItem(productId);
            this.imgPicture.ImageUrl = "/Pics/" + product.PictureFileName;
            this.lblName.Text = product.Name;
            this.lblDescription.Text = product.Description;
            this.lblDescription.Text = product.Description;
            this.lblBrand.Text = product.CatalogBrand.Brand;
            this.lblType.Text = product.CatalogType.Type;
            this.lblPrice.Text = product.Price.ToString();
            this.lblPictureName.Text = product.PictureFileName;
            this.lblStock.Text = product.AvailableStock.ToString();
            this.lblRestock.Text = product.RestockThreshold .ToString();
            this.lblMaxstock.Text = product.MaxStockThreshold.ToString();
            this.btnEditPage.NavigateUrl = "~/Catalog/Edit.aspx?Id=" + product.Id;
            CatalogService.Dispose();
        }
    }
}