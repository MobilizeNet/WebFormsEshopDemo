#pragma warning disable
#line 1 "Catalog\\Create.aspx.cs"
#pragma warning disable
#line 1 "Catalog\\Create.aspx.cs"
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace eShopLegacyWebForms.Catalog
{

   [Observable]
   public partial class Create : Mobilize.Web.UI.Controls.Page
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.Services.ICatalogService CatalogService_k__BackingField;
#line 16


      [Intercepted]
      public ICatalogService CatalogService 
#line 16
                                            { 
#line 16
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_CatalogService)<=0){this.CatalogService_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<eShopLegacyWebForms.Services.ICatalogService>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogService;}return this.CatalogService_k__BackingField;} 
#line 16

#line 16
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<ICatalogService >(this,_Mobilize_References,0,this.CatalogService_k__BackingField,(eShopLegacyWebForms.Services.ICatalogService)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogService;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogService;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogService_k__BackingField=(eShopLegacyWebForms.Services.ICatalogService)value;} 
#line 16
                                                        }

#line 17

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
            Response.Redirect("eShopLegacyWebForms.Home");
         }
     }

   }
}
#pragma warning restore
