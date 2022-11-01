#pragma warning disable
#line 1 "Catalog\\Create.aspx.cs"
#line hidden
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace eShopLegacyWebForms.Catalog
{
    public partial class Create
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[15];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogService) > 0)
            {
                yield return "CatalogService";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_txt_Name) > 0)
            {
                yield return "txt_Name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_NameValidator) > 0)
            {
                yield return "NameValidator";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Description) > 0)
            {
                yield return "Description";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Brand) > 0)
            {
                yield return "Brand";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Type) > 0)
            {
                yield return "Type";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Price) > 0)
            {
                yield return "Price";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_PriceValidator) > 0)
            {
                yield return "PriceValidator";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Stock) > 0)
            {
                yield return "Stock";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_StockValidator) > 0)
            {
                yield return "StockValidator";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Restock) > 0)
            {
                yield return "Restock";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_RestockValidator) > 0)
            {
                yield return "RestockValidator";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Maxstock) > 0)
            {
                yield return "Maxstock";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_MaxstockValidator) > 0)
            {
                yield return "MaxstockValidator";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnCreate) > 0)
            {
                yield return "btnCreate";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "CatalogService":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogService) > 0;
                case "txt_Name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_txt_Name) > 0;
                case "NameValidator":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_NameValidator) > 0;
                case "Description":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Description) > 0;
                case "Brand":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Brand) > 0;
                case "Type":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Type) > 0;
                case "Price":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Price) > 0;
                case "PriceValidator":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_PriceValidator) > 0;
                case "Stock":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Stock) > 0;
                case "StockValidator":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_StockValidator) > 0;
                case "Restock":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Restock) > 0;
                case "RestockValidator":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_RestockValidator) > 0;
                case "Maxstock":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Maxstock) > 0;
                case "MaxstockValidator":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_MaxstockValidator) > 0;
                case "btnCreate":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnCreate) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["CatalogService"] = _Mobilize_References[0];
            refs["txt_Name"] = _Mobilize_References[1];
            refs["NameValidator"] = _Mobilize_References[2];
            refs["Description"] = _Mobilize_References[3];
            refs["Brand"] = _Mobilize_References[4];
            refs["Type"] = _Mobilize_References[5];
            refs["Price"] = _Mobilize_References[6];
            refs["PriceValidator"] = _Mobilize_References[7];
            refs["Stock"] = _Mobilize_References[8];
            refs["StockValidator"] = _Mobilize_References[9];
            refs["Restock"] = _Mobilize_References[10];
            refs["RestockValidator"] = _Mobilize_References[11];
            refs["Maxstock"] = _Mobilize_References[12];
            refs["MaxstockValidator"] = _Mobilize_References[13];
            refs["btnCreate"] = _Mobilize_References[14];
            return refs;
        }

        protected override void _Mobilize_CleanChanges()
        {
            if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
            {
                this._Mobilize_DirtyFlag_0 = 0;
                this._Mobilize_LoadedFlag_0 = 0;
                this._Mobilize_ControlFlag = 0;
            }

            base._Mobilize_CleanChanges();
        }

        protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
        {
            foreach (var baseRef in base._Mobilize_GetReferences())
            {
                yield return baseRef;
            }

            var ref_CatalogService = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.CatalogService);
            if (ref_CatalogService != null)
                yield return ref_CatalogService;
            var ref_txt_Name = (Mobilize.WebMap.Common.Core.IObservable)this.txt_Name;
            if (ref_txt_Name != null)
                yield return ref_txt_Name;
            var ref_NameValidator = (Mobilize.WebMap.Common.Core.IObservable)this.NameValidator;
            if (ref_NameValidator != null)
                yield return ref_NameValidator;
            var ref_Description = (Mobilize.WebMap.Common.Core.IObservable)this.Description;
            if (ref_Description != null)
                yield return ref_Description;
            var ref_Brand = (Mobilize.WebMap.Common.Core.IObservable)this.Brand;
            if (ref_Brand != null)
                yield return ref_Brand;
            var ref_Type = (Mobilize.WebMap.Common.Core.IObservable)this.Type;
            if (ref_Type != null)
                yield return ref_Type;
            var ref_Price = (Mobilize.WebMap.Common.Core.IObservable)this.Price;
            if (ref_Price != null)
                yield return ref_Price;
            var ref_PriceValidator = (Mobilize.WebMap.Common.Core.IObservable)this.PriceValidator;
            if (ref_PriceValidator != null)
                yield return ref_PriceValidator;
            var ref_Stock = (Mobilize.WebMap.Common.Core.IObservable)this.Stock;
            if (ref_Stock != null)
                yield return ref_Stock;
            var ref_StockValidator = (Mobilize.WebMap.Common.Core.IObservable)this.StockValidator;
            if (ref_StockValidator != null)
                yield return ref_StockValidator;
            var ref_Restock = (Mobilize.WebMap.Common.Core.IObservable)this.Restock;
            if (ref_Restock != null)
                yield return ref_Restock;
            var ref_RestockValidator = (Mobilize.WebMap.Common.Core.IObservable)this.RestockValidator;
            if (ref_RestockValidator != null)
                yield return ref_RestockValidator;
            var ref_Maxstock = (Mobilize.WebMap.Common.Core.IObservable)this.Maxstock;
            if (ref_Maxstock != null)
                yield return ref_Maxstock;
            var ref_MaxstockValidator = (Mobilize.WebMap.Common.Core.IObservable)this.MaxstockValidator;
            if (ref_MaxstockValidator != null)
                yield return ref_MaxstockValidator;
            var ref_btnCreate = (Mobilize.WebMap.Common.Core.IObservable)this.btnCreate;
            if (ref_btnCreate != null)
                yield return ref_btnCreate;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_CatalogService = (uint)1 << 0;
        const uint _Mobilize_Loaded_CatalogService = (uint)1 << 0;
        const uint _Mobilize_Dirty_txt_Name = (uint)1 << 1;
        const uint _Mobilize_Loaded_txt_Name = (uint)1 << 1;
        const uint _Mobilize_Dirty_NameValidator = (uint)1 << 2;
        const uint _Mobilize_Loaded_NameValidator = (uint)1 << 2;
        const uint _Mobilize_Dirty_Description = (uint)1 << 3;
        const uint _Mobilize_Loaded_Description = (uint)1 << 3;
        const uint _Mobilize_Dirty_Brand = (uint)1 << 4;
        const uint _Mobilize_Loaded_Brand = (uint)1 << 4;
        const uint _Mobilize_Dirty_Type = (uint)1 << 5;
        const uint _Mobilize_Loaded_Type = (uint)1 << 5;
        const uint _Mobilize_Dirty_Price = (uint)1 << 6;
        const uint _Mobilize_Loaded_Price = (uint)1 << 6;
        const uint _Mobilize_Dirty_PriceValidator = (uint)1 << 7;
        const uint _Mobilize_Loaded_PriceValidator = (uint)1 << 7;
        const uint _Mobilize_Dirty_Stock = (uint)1 << 8;
        const uint _Mobilize_Loaded_Stock = (uint)1 << 8;
        const uint _Mobilize_Dirty_StockValidator = (uint)1 << 9;
        const uint _Mobilize_Loaded_StockValidator = (uint)1 << 9;
        const uint _Mobilize_Dirty_Restock = (uint)1 << 10;
        const uint _Mobilize_Loaded_Restock = (uint)1 << 10;
        const uint _Mobilize_Dirty_RestockValidator = (uint)1 << 11;
        const uint _Mobilize_Loaded_RestockValidator = (uint)1 << 11;
        const uint _Mobilize_Dirty_Maxstock = (uint)1 << 12;
        const uint _Mobilize_Loaded_Maxstock = (uint)1 << 12;
        const uint _Mobilize_Dirty_MaxstockValidator = (uint)1 << 13;
        const uint _Mobilize_Loaded_MaxstockValidator = (uint)1 << 13;
        const uint _Mobilize_Dirty_btnCreate = (uint)1 << 14;
        const uint _Mobilize_Loaded_btnCreate = (uint)1 << 14;
#line 13
    }
}