using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public class CatalogType
   {

      [Intercepted]
      public int Id { get; set; }

      [Intercepted]
      public string Type { get; set; }

   }
}