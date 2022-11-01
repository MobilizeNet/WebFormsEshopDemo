#pragma warning disable
#line 1 "Services\\ICatalogService.cs"
#pragma warning disable
#line 1 "Services\\ICatalogService.cs"
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.ViewModel;
using System;
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Services
{
    public interface ICatalogService : IDisposable
    {
        CatalogItem FindCatalogItem(int id);
        IEnumerable<CatalogBrand> GetCatalogBrands();
        CatalogItemsViewModel<CatalogItem> GetCatalogItems();
        IEnumerable<CatalogType> GetCatalogTypes();
        void CreateCatalogItem(CatalogItem catalogItem);
        void UpdateCatalogItem(CatalogItem catalogItem);
        void RemoveCatalogItem(CatalogItem catalogItem);
    }
}
#pragma warning restore
