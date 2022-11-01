#pragma warning disable
#line 1 "Models\\CatalogItemHiLoGenerator.cs"
#pragma warning disable
#line 1 "Models\\CatalogItemHiLoGenerator.cs"
using System;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public partial class CatalogItemHiLoGenerator
   {
       private const int HiLoIncrement = 10;

#line hidden
                                           
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int sequenceId_k__BackingField;
#line 14
                                           

      [Intercepted]
      private int sequenceId 
#line 14
                             { 
#line 14
                               get                                  
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.sequenceId_k__BackingField;} 
#line 14

#line 14
                                    set                                       
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sequenceId;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sequenceId_k__BackingField=(int)value;} 
#line 14
                                         } 
#line 15

#line hidden
                                                
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int remainningLoIds_k__BackingField;
#line 17
                                                

      [Intercepted]
      private int remainningLoIds 
#line 17
                                  { 
#line 17
                                    get                                       
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.remainningLoIds_k__BackingField;} 
#line 17

#line 17
                                         set                                            
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_remainningLoIds;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.remainningLoIds_k__BackingField=(int)value;} 
#line 17
                                              } 
#line 18

#line hidden
                                                
[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private object sequenceLock_k__BackingField;
#line 20
                                                

      [Intercepted]
      private object sequenceLock 
#line 20
                                  { 
#line 20
                                    get                                       
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_sequenceLock)<=0){this.sequenceLock_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<object>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sequenceLock;}return this.sequenceLock_k__BackingField;} 
#line 20

#line 20
                                         set                                            
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<object >(this,_Mobilize_References,0,this.sequenceLock_k__BackingField,(object)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_sequenceLock;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_sequenceLock;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.sequenceLock_k__BackingField=(object)value;} 
#line 20
                                              } 
#line 21

      public int GetNextSequenceValue(CatalogDBContext db)
      {
          lock (sequenceLock)
          {
              if (remainningLoIds == 0)
              {
                  var rawQuery = db.Database.SqlQuery<Int64>("SELECT NEXT VALUE FOR catalog_hilo;");
                  sequenceId = (int)rawQuery.Single();
                  remainningLoIds = HiLoIncrement - 1;
                  return sequenceId;
              }
              else
              {
                  remainningLoIds--;
                  return ++sequenceId;
              }
          }
      }

   }
}
#pragma warning restore
