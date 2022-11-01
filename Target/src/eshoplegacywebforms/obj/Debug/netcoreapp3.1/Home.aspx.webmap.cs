#pragma warning disable
#line 1 "Home.aspx.cs"
#pragma warning disable
#line 1 "Home.aspx.cs"
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

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.Services.ICatalogService CatalogService_k__BackingField;
#line 15


      [Intercepted]
      public ICatalogService CatalogService 
#line 15
                                            { 
#line 15
                                              get                                                 
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_CatalogService)<=0){this.CatalogService_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<eShopLegacyWebForms.Services.ICatalogService>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogService;}return this.CatalogService_k__BackingField;} 
#line 15

#line 15
                                                   set                                                      
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<ICatalogService >(this,_Mobilize_References,0,this.CatalogService_k__BackingField,(eShopLegacyWebForms.Services.ICatalogService)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogService;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogService;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogService_k__BackingField=(eShopLegacyWebForms.Services.ICatalogService)value;} 
#line 15
                                                        }

#line 16

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.ViewModel.CatalogItemsViewModel<eShopLegacyWebForms.Models.CatalogItem> Model_k__BackingField;
#line 19


      [Intercepted]

      protected CatalogItemsViewModel<CatalogItem> Model 
#line 19
                                                         { 
#line 19
                                                           get                                                              
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Model)<=0){this.Model_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<eShopLegacyWebForms.ViewModel.CatalogItemsViewModel<eShopLegacyWebForms.Models.CatalogItem>>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Model;;} return this.Model_k__BackingField; } 
#line 19

#line 19
                                                                set                                                                   
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<eShopLegacyWebForms.ViewModel.CatalogItemsViewModel<eShopLegacyWebForms.Models.CatalogItem>>(this,_Mobilize_References,1,this.Model_k__BackingField,(eShopLegacyWebForms.ViewModel.CatalogItemsViewModel<eShopLegacyWebForms.Models.CatalogItem>)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Model;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Model;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Model_k__BackingField=(eShopLegacyWebForms.ViewModel.CatalogItemsViewModel<eShopLegacyWebForms.Models.CatalogItem>)value;} 
#line 19
                                                                     }

#line 20

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
#pragma warning restore
