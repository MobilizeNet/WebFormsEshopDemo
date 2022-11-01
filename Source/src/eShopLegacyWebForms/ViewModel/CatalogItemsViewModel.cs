using System.Collections.Generic;

namespace eShopLegacyWebForms.ViewModel
{
    public class CatalogItemsViewModel<TEntity> where TEntity : class
    {
        public int ActualPage { get; private set; }

        public int ItemsPerPage { get; private set; }

        public long TotalItems { get; private set; }

        public int TotalPages { get; set; }

        public IEnumerable<TEntity> Data { get; private set; }

        public CatalogItemsViewModel(IEnumerable<TEntity> data)
        {
            Data = data;
        }
    }
}
