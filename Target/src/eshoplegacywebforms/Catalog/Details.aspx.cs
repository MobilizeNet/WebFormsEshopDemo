using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Catalog
{

   [Observable]
   public partial class Details : Mobilize.Web.UI.Controls.Page
   {

      [Intercepted]


      protected CatalogItem product { get; set; }

      [Intercepted]

      public ICatalogService CatalogService { get; set; }

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
         this.btnEditPage.NavigateUrl = "eShopLegacyWebForms.Catalog.Edit?Id=" + product.Id;
         CatalogService.Dispose();
     }

   }
}