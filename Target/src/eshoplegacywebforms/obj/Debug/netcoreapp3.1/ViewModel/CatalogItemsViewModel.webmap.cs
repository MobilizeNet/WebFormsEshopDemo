#pragma warning disable
#line 1 "ViewModel\\CatalogItemsViewModel.cs"
#pragma warning disable
#line 1 "ViewModel\\CatalogItemsViewModel.cs"
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.ViewModel
{

   [Observable]
   public partial class CatalogItemsViewModel<TEntity>
      where TEntity : class
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int ActualPage_k__BackingField;
#line 13


      [Intercepted]
      public int ActualPage 
#line 13
                            { 
#line 13
                              get                                 
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.ActualPage_k__BackingField;} 
#line 13

#line 13
private                                            set                                              
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ActualPage;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ActualPage_k__BackingField=(int)value;} 
#line 13
                                                }

#line 14

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int ItemsPerPage_k__BackingField;
#line 17


      [Intercepted]

      public int ItemsPerPage 
#line 17
                              { 
#line 17
                                get                                   
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.ItemsPerPage_k__BackingField;} 
#line 17

#line 17
private                                              set                                                
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ItemsPerPage;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ItemsPerPage_k__BackingField=(int)value;} 
#line 17
                                                  }

#line 18

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private long TotalItems_k__BackingField;
#line 21


      [Intercepted]

      public long TotalItems 
#line 21
                             { 
#line 21
                               get                                  
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.TotalItems_k__BackingField;} 
#line 21

#line 21
private                                             set                                               
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_TotalItems;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.TotalItems_k__BackingField=(long)value;} 
#line 21
                                                 }

#line 22

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int TotalPages_k__BackingField;
#line 25


      [Intercepted]

      public int TotalPages 
#line 25
                            { 
#line 25
                              get                                 
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.TotalPages_k__BackingField;} 
#line 25

#line 25
                                   set                                      
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_TotalPages;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.TotalPages_k__BackingField=(int)value;} 
#line 25
                                        }

#line 26

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Collections.Generic.IEnumerable<TEntity> Data_k__BackingField;
#line 29


      [Intercepted]

      public IEnumerable<TEntity> Data 
#line 29
                                       { 
#line 29
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_Data)<=0){this.Data_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Collections.Generic.IEnumerable<TEntity>>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Data;}return this.Data_k__BackingField;} 
#line 29

#line 29
private                                                       set                                                         
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<IEnumerable<TEntity> >(this,_Mobilize_References,0,this.Data_k__BackingField,(System.Collections.Generic.IEnumerable<TEntity>)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Data;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_Data;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Data_k__BackingField=(System.Collections.Generic.IEnumerable<TEntity>)value;} 
#line 29
                                                           }

#line 30


      public CatalogItemsViewModel(IEnumerable<TEntity> data)
      {
          Data = data;
      }
   }
}
#pragma warning restore
