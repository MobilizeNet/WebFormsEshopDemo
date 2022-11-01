#pragma warning disable
#line 1 "Models\\CatalogBrand.cs"
#pragma warning disable
#line 1 "Models\\CatalogBrand.cs"
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public partial class CatalogBrand
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Id_k__BackingField;
#line 11


      [Intercepted]
      public int Id 
#line 11
                    { 
#line 11
                      get                         
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Id_k__BackingField;} 
#line 11

#line 11
                           set                              
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Id;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Id_k__BackingField=(int)value;} 
#line 11
                                }

#line 12

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Brand_k__BackingField;
#line 14


      [Intercepted]
      public string Brand 
#line 14
                          { 
#line 14
                            get                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Brand_k__BackingField;} 
#line 14

#line 14
                                 set                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Brand;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Brand_k__BackingField=(string)value;} 
#line 14
                                      }

#line 15

   }
}
#pragma warning restore
