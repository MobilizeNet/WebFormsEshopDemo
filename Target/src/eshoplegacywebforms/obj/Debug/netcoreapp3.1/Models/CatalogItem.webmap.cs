#pragma warning disable
#line 1 "Models\\CatalogItem.cs"
#pragma warning disable
#line 1 "Models\\CatalogItem.cs"
using System.ComponentModel.DataAnnotations;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public partial class CatalogItem
   {
       public const string DefaultPictureName = "dummy.png";

       public CatalogItem()
       {
           PictureFileName = DefaultPictureName;
       }

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Id_k__BackingField;
#line 18


      [Intercepted]
      public int Id 
#line 18
                    { 
#line 18
                      get                         
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Id_k__BackingField;} 
#line 18

#line 18
                           set                              
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Id;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Id_k__BackingField=(int)value;} 
#line 18
                                }

#line 19

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Name_k__BackingField;
#line 22


      [Intercepted]

      public string Name 
#line 22
                         { 
#line 22
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Name_k__BackingField;} 
#line 22

#line 22
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Name;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Name_k__BackingField=(string)value;} 
#line 22
                                     }

#line 23

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Description_k__BackingField;
#line 26


      [Intercepted]

      public string Description 
#line 26
                                { 
#line 26
                                  get                                     
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Description_k__BackingField;} 
#line 26

#line 26
                                       set                                          
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Description;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Description_k__BackingField=(string)value;} 
#line 26
                                            }

#line 27

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private decimal Price_k__BackingField;
#line 32


      // decimal(18,2)
      [RegularExpression(@"^\d+(\.\d{0,2})*$", ErrorMessage = "The field Price must be a positive number with maximum two decimals.")]
      [Range(0, 9999999999999999.99)]
      [Intercepted]
      public decimal Price 
#line 32
                           { 
#line 32
                             get                                
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Price_k__BackingField;} 
#line 32

#line 32
                                  set                                     
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Price;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Price_k__BackingField=(decimal)value;} 
#line 32
                                       }

#line 33

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string PictureFileName_k__BackingField;
#line 36


      [Display(Name = "Picture name")]
      [Intercepted]
      public string PictureFileName 
#line 36
                                    { 
#line 36
                                      get                                         
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.PictureFileName_k__BackingField;} 
#line 36

#line 36
                                           set                                              
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_PictureFileName;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.PictureFileName_k__BackingField=(string)value;} 
#line 36
                                                }

#line 37

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string PictureUri_k__BackingField;
#line 40


      [Intercepted]

      public string PictureUri 
#line 40
                               { 
#line 40
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.PictureUri_k__BackingField;} 
#line 40

#line 40
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_PictureUri;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.PictureUri_k__BackingField=(string)value;} 
#line 40
                                           }

#line 41

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int CatalogTypeId_k__BackingField;
#line 44


      [Display(Name = "Type")]
      [Intercepted]
      public int CatalogTypeId 
#line 44
                               { 
#line 44
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.CatalogTypeId_k__BackingField;} 
#line 44

#line 44
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogTypeId;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogTypeId_k__BackingField=(int)value;} 
#line 44
                                           }

#line 45

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.Models.CatalogType CatalogType_k__BackingField;
#line 48


      [Display(Name = "Type")]
      [Intercepted]
      public CatalogType CatalogType 
#line 48
                                     { 
#line 48
                                       get                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_CatalogType)<=0){this.CatalogType_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<eShopLegacyWebForms.Models.CatalogType>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogType;;} return this.CatalogType_k__BackingField; } 
#line 48

#line 48
                                            set                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<eShopLegacyWebForms.Models.CatalogType>(this,_Mobilize_References,0,this.CatalogType_k__BackingField,(eShopLegacyWebForms.Models.CatalogType)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogType;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogType;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogType_k__BackingField=(eShopLegacyWebForms.Models.CatalogType)value;} 
#line 48
                                                 }

#line 49

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int CatalogBrandId_k__BackingField;
#line 52


      [Display(Name = "Brand")]
      [Intercepted]
      public int CatalogBrandId 
#line 52
                                { 
#line 52
                                  get                                     
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.CatalogBrandId_k__BackingField;} 
#line 52

#line 52
                                       set                                          
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogBrandId;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogBrandId_k__BackingField=(int)value;} 
#line 52
                                            }

#line 53

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.Models.CatalogBrand CatalogBrand_k__BackingField;
#line 56


      [Display(Name = "Brand")]
      [Intercepted]
      public CatalogBrand CatalogBrand 
#line 56
                                       { 
#line 56
                                         get                                            
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_CatalogBrand)<=0){this.CatalogBrand_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<eShopLegacyWebForms.Models.CatalogBrand>(this,_Mobilize_References,1);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogBrand;;} return this.CatalogBrand_k__BackingField; } 
#line 56

#line 56
                                              set                                                 
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<eShopLegacyWebForms.Models.CatalogBrand>(this,_Mobilize_References,1,this.CatalogBrand_k__BackingField,(eShopLegacyWebForms.Models.CatalogBrand)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CatalogBrand;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_CatalogBrand;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CatalogBrand_k__BackingField=(eShopLegacyWebForms.Models.CatalogBrand)value;} 
#line 56
                                                   }

#line 57

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int AvailableStock_k__BackingField;
#line 62


      // Quantity in stock
      [Range(0, 10000000, ErrorMessage = "The field Stock must be between 0 and 10 million.")]
      [Display(Name = "Stock")]
      [Intercepted]
      public int AvailableStock 
#line 62
                                { 
#line 62
                                  get                                     
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.AvailableStock_k__BackingField;} 
#line 62

#line 62
                                       set                                          
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_AvailableStock;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.AvailableStock_k__BackingField=(int)value;} 
#line 62
                                            }

#line 63

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int RestockThreshold_k__BackingField;
#line 68


      // Available stock at which we should reorder
      [Range(0, 10000000, ErrorMessage = "The field Stock must be between 0 and 10 million.")]
      [Display(Name = "Restock")]
      [Intercepted]
      public int RestockThreshold 
#line 68
                                  { 
#line 68
                                    get                                       
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.RestockThreshold_k__BackingField;} 
#line 68

#line 68
                                         set                                            
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_RestockThreshold;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.RestockThreshold_k__BackingField=(int)value;} 
#line 68
                                              }

#line 69

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int MaxStockThreshold_k__BackingField;
#line 74


      // Maximum number of units that can be in-stock at any time (due to physicial/logistical constraints in warehouses)
      [Range(0, 10000000, ErrorMessage = "The field Stock must be between 0 and 10 million.")]
      [Display(Name = "Max stock")]
      [Intercepted]
      public int MaxStockThreshold 
#line 74
                                   { 
#line 74
                                     get                                        
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.MaxStockThreshold_k__BackingField;} 
#line 74

#line 74
                                          set                                             
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_MaxStockThreshold;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.MaxStockThreshold_k__BackingField=(int)value;} 
#line 74
                                               }

#line 75

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private bool OnReorder_k__BackingField;
#line 82


      [Intercepted]

      /// <summary>
      /// True if item is on reorder
      /// </summary>
      public
      bool OnReorder 
#line 82
                     { 
#line 82
                       get                          
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.OnReorder_k__BackingField;} 
#line 82

#line 82
                            set                               
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_OnReorder;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.OnReorder_k__BackingField=(bool)value;} 
#line 82
                                 }

#line 83

   }
}
#pragma warning restore
