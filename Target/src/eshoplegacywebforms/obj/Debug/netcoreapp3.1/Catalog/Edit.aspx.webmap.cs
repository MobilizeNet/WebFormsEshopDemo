#pragma warning disable
#line 1 "Catalog\\Edit.aspx.cs"
#pragma warning disable
#line 1 "Catalog\\Edit.aspx.cs"
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace eShopLegacyWebForms.Catalog
{

   [Observable]
   public partial class Edit : Mobilize.Web.UI.Controls.Page
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.Models.CatalogItem product_k__BackingField;
#line 16


      [Intercepted]
      protected CatalogItem product 
#line 16
                                    { 
#line 16
                                      get                                         
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_product)<=0){this.product_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<eShopLegacyWebForms.Models.CatalogItem>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_product;;} return this.product_k__BackingField; } 
#line 16

#line 16
                                           set                                              
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<eShopLegacyWebForms.Models.CatalogItem>(this,_Mobilize_References,0,this.product_k__BackingField,(eShopLegacyWebForms.Models.CatalogItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_product;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_product;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.product_k__BackingField=(eShopLegacyWebForms.Models.CatalogItem)value;} 
#line 16
                                                }

#line 17

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.Services.ICatalogService CatalogService_k__BackingField;
#line 20


      [Intercepted]

      public ICatalogService CatalogService 
#line 20
                                            { 
#line 20
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_CatalogService)<=0){this.CatalogService_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<eShopLegacyWebForms.Services.ICatalogService>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogService;}return this.CatalogService_k__BackingField;} 
#line 20

#line 20
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<ICatalogService >(this,_Mobilize_References,1,this.CatalogService_k__BackingField,(eShopLegacyWebForms.Services.ICatalogService)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogService;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogService;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogService_k__BackingField=(eShopLegacyWebForms.Services.ICatalogService)value;} 
#line 20
                                                        }

#line 21

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
            Response.Redirect("eShopLegacyWebForms.Home");
         }
     }

   }
}
#pragma warning restore
