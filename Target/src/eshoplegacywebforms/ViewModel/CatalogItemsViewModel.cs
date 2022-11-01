using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.ViewModel
{

   [Observable]
   public class CatalogItemsViewModel<TEntity>
      where TEntity : class
   {

      [Intercepted]
      public int ActualPage { get; private set; }

      [Intercepted]

      public int ItemsPerPage { get; private set; }

      [Intercepted]

      public long TotalItems { get; private set; }

      [Intercepted]

      public int TotalPages { get; set; }

      [Intercepted]

      public IEnumerable<TEntity> Data { get; private set; }


      public CatalogItemsViewModel(IEnumerable<TEntity> data)
      {
          Data = data;
      }
   }
}