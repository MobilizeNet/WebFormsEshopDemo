using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace eShopLegacyWebForms.Catalog
{
    public partial class Edit : Page
    {        
        protected CatalogItem product;

        public ICatalogService CatalogService;

        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogService = new CatalogService();
            if (!Page.IsPostBack)
            {
                var productId = Convert.ToInt32(Request.QueryString["Id"]);
                product = CatalogService.FindCatalogItem(productId);

                BrandDropDownList.DataSource = CatalogService.GetCatalogBrands();
                BrandDropDownList.SelectedValue = product.CatalogBrandId.ToString();
                BrandDropDownList.DataBind();                

                TypeDropDownList.DataSource = CatalogService.GetCatalogTypes();
                TypeDropDownList.SelectedValue = product.CatalogTypeId.ToString();
                TypeDropDownList.DataBind();

                this.img1.ImageUrl = "/Pics/" + product.PictureFileName;
                this.txt_Name.Text = product.Name;
                this.Description.Text = product.Description;
                this.Description.Text = product.Description;
                this.Price.Text = product.Price.ToString();
                this.PictureFileName.Text = product.PictureFileName;
                this.Stock.Text = product.AvailableStock.ToString();
                this.Restock.Text = product.RestockThreshold.ToString();
                this.Maxstock.Text = product.MaxStockThreshold.ToString();
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            if (this.ModelState.IsValid)
            {
                var catalogItem = new CatalogItem
                {
                    Id = Convert.ToInt32(Request.QueryString["Id"]),
                    Name = txt_Name.Text,
                    Description = Description.Text,
                    CatalogBrandId = int.Parse(BrandDropDownList.SelectedValue),
                    CatalogTypeId = int.Parse(TypeDropDownList.SelectedValue),
                    Price = decimal.Parse(Price.Text),
                    PictureFileName = PictureFileName.Text,
                    AvailableStock = int.Parse(Stock.Text),
                    RestockThreshold = int.Parse(Restock.Text),
                    MaxStockThreshold = int.Parse(Maxstock.Text)
                };
                CatalogService.UpdateCatalogItem(catalogItem);
                CatalogService.Dispose();
                Response.Redirect("~/Home.aspx");
            }
        }
    }
}