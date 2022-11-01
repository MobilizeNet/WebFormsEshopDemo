#pragma warning disable
#line 1 "Catalog\\Delete.aspx.cs"
#pragma warning disable
#line 1 "Catalog\\Delete.aspx.cs"
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Catalog
{

   [Observable]
   public partial class Delete : Mobilize.Web.UI.Controls.Page
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.Models.CatalogItem productToDelete_k__BackingField;
#line 16


      [Intercepted]


      protected CatalogItem productToDelete 
#line 16
                                            { 
#line 16
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_productToDelete)<=0){this.productToDelete_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<eShopLegacyWebForms.Models.CatalogItem>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_productToDelete;;} return this.productToDelete_k__BackingField; } 
#line 16

#line 16
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<eShopLegacyWebForms.Models.CatalogItem>(this,_Mobilize_References,0,this.productToDelete_k__BackingField,(eShopLegacyWebForms.Models.CatalogItem)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_productToDelete;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_productToDelete;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.productToDelete_k__BackingField=(eShopLegacyWebForms.Models.CatalogItem)value;} 
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
         Response.Redirect("eShopLegacyWebForms.Home");
      }

   }
}
#pragma warning restore
