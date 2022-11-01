#pragma warning disable
#line 1 "Models\\Infrastructure\\CatalogDBInitializer.cs"
#pragma warning disable
#line 1 "Models\\Infrastructure\\CatalogDBInitializer.cs"
using System;
using System.Data.Entity;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace eShopLegacyWebForms.Models.Infrastructure
{

   [Observable]
   public partial class CatalogDBInitializer : DropCreateDatabaseIfModelChanges<CatalogDBContext>
   {
       private const string DBCatalogSequenceName = "catalog_type_hilo";
       private const string DBBrandSequenceName = "catalog_brand_hilo";
       private const string CatalogItemHiLoSequenceScript = @"Models\Infrastructure\dbo.catalog_hilo.Sequence.sql";
       private const string CatalogBrandHiLoSequenceScript = @"Models\Infrastructure\dbo.catalog_brand_hilo.Sequence.sql";
       private const string CatalogTypeHiLoSequenceScript = @"Models\Infrastructure\dbo.catalog_type_hilo.Sequence.sql";

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private eShopLegacyWebForms.Models.CatalogItemHiLoGenerator indexGenerator_k__BackingField;
#line 23


      [Intercepted]

      private CatalogItemHiLoGenerator indexGenerator 
#line 23
                                                      { 
#line 23
                                                        get                                                           
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_indexGenerator)<=0){this.indexGenerator_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetObservable<eShopLegacyWebForms.Models.CatalogItemHiLoGenerator>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_indexGenerator;;} return this.indexGenerator_k__BackingField; } 
#line 23

#line 23
                                                             set                                                                
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetObservable<eShopLegacyWebForms.Models.CatalogItemHiLoGenerator>(this,_Mobilize_References,0,this.indexGenerator_k__BackingField,(eShopLegacyWebForms.Models.CatalogItemHiLoGenerator)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_indexGenerator;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_indexGenerator;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.indexGenerator_k__BackingField=(eShopLegacyWebForms.Models.CatalogItemHiLoGenerator)value;} 
#line 23
                                                                  }

#line 24
      public CatalogDBInitializer()
      {
          this.indexGenerator = new CatalogItemHiLoGenerator();
      }

      protected override void Seed(CatalogDBContext context)
      {
          ExecuteScript(context, CatalogItemHiLoSequenceScript);
          ExecuteScript(context, CatalogBrandHiLoSequenceScript);
          ExecuteScript(context, CatalogTypeHiLoSequenceScript);

          AddCatalogTypes(context);
          AddCatalogBrands(context);
          AddCatalogItems(context);
          AddCatalogItemPictures();
      }

      private void AddCatalogTypes(CatalogDBContext context)
      {
          var preconfiguredTypes = PreconfiguredData.GetPreconfiguredCatalogTypes();

          int sequenceId = GetSequenceIdFromSelectedDBSequence(context, DBCatalogSequenceName);
          foreach (var type in preconfiguredTypes)
          {
              type.Id = sequenceId;
              context.CatalogTypes.Add(type);
              sequenceId++;
          }

          context.SaveChanges();
      }

      private void AddCatalogBrands(CatalogDBContext context)
      {
          var preconfiguredBrands = PreconfiguredData.GetPreconfiguredCatalogBrands();

          int sequenceId = GetSequenceIdFromSelectedDBSequence(context, DBBrandSequenceName);
          foreach (var brand in preconfiguredBrands)
          {
              brand.Id = sequenceId;
              context.CatalogBrands.Add(brand);
              sequenceId++;
          }

          context.SaveChanges();
      }

      private void AddCatalogItems(CatalogDBContext context)
      {
          var preconfiguredItems = PreconfiguredData.GetPreconfiguredCatalogItems();

          foreach (var item in preconfiguredItems)
          {
              var sequenceId = indexGenerator.GetNextSequenceValue(context);
              item.Id = sequenceId;
              context.CatalogItems.Add(item);
          }

          context.SaveChanges();
      }

      private static int GetSequenceIdFromSelectedDBSequence(CatalogDBContext context, string dBSequenceName)
      {
          var rawQuery = context.Database.SqlQuery<Int64>($"SELECT NEXT VALUE FOR {dBSequenceName}");
          var sequenceId = (int)rawQuery.Single();
          return sequenceId;
      }

      private void ExecuteScript(CatalogDBContext context, string scriptFile)
      {
          var scriptFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, scriptFile);
          context.Database.ExecuteSqlCommand(File.ReadAllText(scriptFilePath));
      }

      private void AddCatalogItemPictures()
      {
          var contentRootPath = Directory.GetCurrentDirectory();
          DirectoryInfo picturePath = new DirectoryInfo(Path.Combine(contentRootPath, "Pics"));
          foreach (FileInfo file in picturePath.GetFiles())
          {
              file.Delete();
          }

          string zipFileCatalogItemPictures = Path.Combine(contentRootPath, "Setup", "CatalogItems.zip");
         Stub._System.IO.Compression.ZipFile.ExtractToDirectory(zipFileCatalogItemPictures, picturePath.ToString());
      }

   }
}
#pragma warning restore
