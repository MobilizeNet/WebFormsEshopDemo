using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public class CatalogBrand
   {

      [Intercepted]
      public int Id { get; set; }

      [Intercepted]
      public string Brand { get; set; }

   }
}