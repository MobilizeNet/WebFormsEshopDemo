using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using System.Web.UI;

namespace eShopLegacyWebForms.Catalog
{
    public partial class Delete : Page
    {
        

        protected CatalogItem productToDelete;

        public ICatalogService CatalogService;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogService = new CatalogService();
            var productId = Convert.ToInt32(Request.QueryString["id"]);
            productToDelete = CatalogService.FindCatalogItem(productId);
            this.imgPicture.ImageUrl = "/Pics/" + productToDelete.PictureFileName;
            this.lblName.Text = productToDelete.Name;
            this.lblDescription.Text = productToDelete.Description;
            this.lblDescription.Text = productToDelete.Description;
            this.lblBrand.Text = productToDelete.CatalogBrand.Brand;
            this.lblType.Text = productToDelete.CatalogType.Type;
            this.lblPrice.Text = productToDelete.Price.ToString();
            this.lblPictureName.Text = productToDelete.PictureFileName;
            this.lblStock.Text = productToDelete.AvailableStock.ToString();
            this.lblRestock.Text = productToDelete.RestockThreshold.ToString();
            this.lblMaxstock.Text = productToDelete.MaxStockThreshold.ToString();
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            CatalogService.RemoveCatalogItem(productToDelete);
            CatalogService.Dispose();
            Response.Redirect("~/Home.aspx");
        }
    }
}