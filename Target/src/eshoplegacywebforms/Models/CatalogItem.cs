using System.ComponentModel.DataAnnotations;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{

   [Observable]
   public class CatalogItem
   {
       public const string DefaultPictureName = "dummy.png";

       public CatalogItem()
       {
           PictureFileName = DefaultPictureName;
       }

      [Intercepted]
      public int Id { get; set; }

      [Intercepted]

      public string Name { get; set; }

      [Intercepted]

      public string Description { get; set; }

      // decimal(18,2)
      [RegularExpression(@"^\d+(\.\d{0,2})*$", ErrorMessage = "The field Price must be a positive number with maximum two decimals.")]
      [Range(0, 9999999999999999.99)]
      [Intercepted]
      public decimal Price { get; set; }

      [Display(Name = "Picture name")]
      [Intercepted]
      public string PictureFileName { get; set; }

      [Intercepted]

      public string PictureUri { get; set; }

      [Display(Name = "Type")]
      [Intercepted]
      public int CatalogTypeId { get; set; }

      [Display(Name = "Type")]
      [Intercepted]
      public CatalogType CatalogType { get; set; }

      [Display(Name = "Brand")]
      [Intercepted]
      public int CatalogBrandId { get; set; }

      [Display(Name = "Brand")]
      [Intercepted]
      public CatalogBrand CatalogBrand { get; set; }

      // Quantity in stock
      [Range(0, 10000000, ErrorMessage = "The field Stock must be between 0 and 10 million.")]
      [Display(Name = "Stock")]
      [Intercepted]
      public int AvailableStock { get; set; }

      // Available stock at which we should reorder
      [Range(0, 10000000, ErrorMessage = "The field Stock must be between 0 and 10 million.")]
      [Display(Name = "Restock")]
      [Intercepted]
      public int RestockThreshold { get; set; }

      // Maximum number of units that can be in-stock at any time (due to physicial/logistical constraints in warehouses)
      [Range(0, 10000000, ErrorMessage = "The field Stock must be between 0 and 10 million.")]
      [Display(Name = "Max stock")]
      [Intercepted]
      public int MaxStockThreshold { get; set; }

      [Intercepted]

      /// <summary>
      /// True if item is on reorder
      /// </summary>
      public
      bool OnReorder { get; set; }

   }
}