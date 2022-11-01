#pragma warning disable
#line 1 "Catalog\\Details.aspx.cs"
#line hidden
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using System;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Catalog
{
    public partial class Details
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[13];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_product) > 0)
            {
                yield return "product";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogService) > 0)
            {
                yield return "CatalogService";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_imgPicture) > 0)
            {
                yield return "imgPicture";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblName) > 0)
            {
                yield return "lblName";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblDescription) > 0)
            {
                yield return "lblDescription";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblBrand) > 0)
            {
                yield return "lblBrand";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblType) > 0)
            {
                yield return "lblType";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblPrice) > 0)
            {
                yield return "lblPrice";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblPictureName) > 0)
            {
                yield return "lblPictureName";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblStock) > 0)
            {
                yield return "lblStock";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblRestock) > 0)
            {
                yield return "lblRestock";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblMaxstock) > 0)
            {
                yield return "lblMaxstock";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnEditPage) > 0)
            {
                yield return "btnEditPage";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "product":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_product) > 0;
                case "CatalogService":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogService) > 0;
                case "imgPicture":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_imgPicture) > 0;
                case "lblName":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblName) > 0;
                case "lblDescription":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblDescription) > 0;
                case "lblBrand":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblBrand) > 0;
                case "lblType":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblType) > 0;
                case "lblPrice":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblPrice) > 0;
                case "lblPictureName":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblPictureName) > 0;
                case "lblStock":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblStock) > 0;
                case "lblRestock":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblRestock) > 0;
                case "lblMaxstock":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblMaxstock) > 0;
                case "btnEditPage":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnEditPage) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["product"] = _Mobilize_References[0];
            refs["CatalogService"] = _Mobilize_References[1];
            refs["imgPicture"] = _Mobilize_References[2];
            refs["lblName"] = _Mobilize_References[3];
            refs["lblDescription"] = _Mobilize_References[4];
            refs["lblBrand"] = _Mobilize_References[5];
            refs["lblType"] = _Mobilize_References[6];
            refs["lblPrice"] = _Mobilize_References[7];
            refs["lblPictureName"] = _Mobilize_References[8];
            refs["lblStock"] = _Mobilize_References[9];
            refs["lblRestock"] = _Mobilize_References[10];
            refs["lblMaxstock"] = _Mobilize_References[11];
            refs["btnEditPage"] = _Mobilize_References[12];
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

            var ref_product = (Mobilize.WebMap.Common.Core.IObservable)this.product;
            if (ref_product != null)
                yield return ref_product;
            var ref_CatalogService = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.CatalogService);
            if (ref_CatalogService != null)
                yield return ref_CatalogService;
            var ref_imgPicture = (Mobilize.WebMap.Common.Core.IObservable)this.imgPicture;
            if (ref_imgPicture != null)
                yield return ref_imgPicture;
            var ref_lblName = (Mobilize.WebMap.Common.Core.IObservable)this.lblName;
            if (ref_lblName != null)
                yield return ref_lblName;
            var ref_lblDescription = (Mobilize.WebMap.Common.Core.IObservable)this.lblDescription;
            if (ref_lblDescription != null)
                yield return ref_lblDescription;
            var ref_lblBrand = (Mobilize.WebMap.Common.Core.IObservable)this.lblBrand;
            if (ref_lblBrand != null)
                yield return ref_lblBrand;
            var ref_lblType = (Mobilize.WebMap.Common.Core.IObservable)this.lblType;
            if (ref_lblType != null)
                yield return ref_lblType;
            var ref_lblPrice = (Mobilize.WebMap.Common.Core.IObservable)this.lblPrice;
            if (ref_lblPrice != null)
                yield return ref_lblPrice;
            var ref_lblPictureName = (Mobilize.WebMap.Common.Core.IObservable)this.lblPictureName;
            if (ref_lblPictureName != null)
                yield return ref_lblPictureName;
            var ref_lblStock = (Mobilize.WebMap.Common.Core.IObservable)this.lblStock;
            if (ref_lblStock != null)
                yield return ref_lblStock;
            var ref_lblRestock = (Mobilize.WebMap.Common.Core.IObservable)this.lblRestock;
            if (ref_lblRestock != null)
                yield return ref_lblRestock;
            var ref_lblMaxstock = (Mobilize.WebMap.Common.Core.IObservable)this.lblMaxstock;
            if (ref_lblMaxstock != null)
                yield return ref_lblMaxstock;
            var ref_btnEditPage = (Mobilize.WebMap.Common.Core.IObservable)this.btnEditPage;
            if (ref_btnEditPage != null)
                yield return ref_btnEditPage;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_product = (uint)1 << 0;
        const uint _Mobilize_Loaded_product = (uint)1 << 0;
        const uint _Mobilize_Dirty_CatalogService = (uint)1 << 1;
        const uint _Mobilize_Loaded_CatalogService = (uint)1 << 1;
        const uint _Mobilize_Dirty_imgPicture = (uint)1 << 2;
        const uint _Mobilize_Loaded_imgPicture = (uint)1 << 2;
        const uint _Mobilize_Dirty_lblName = (uint)1 << 3;
        const uint _Mobilize_Loaded_lblName = (uint)1 << 3;
        const uint _Mobilize_Dirty_lblDescription = (uint)1 << 4;
        const uint _Mobilize_Loaded_lblDescription = (uint)1 << 4;
        const uint _Mobilize_Dirty_lblBrand = (uint)1 << 5;
        const uint _Mobilize_Loaded_lblBrand = (uint)1 << 5;
        const uint _Mobilize_Dirty_lblType = (uint)1 << 6;
        const uint _Mobilize_Loaded_lblType = (uint)1 << 6;
        const uint _Mobilize_Dirty_lblPrice = (uint)1 << 7;
        const uint _Mobilize_Loaded_lblPrice = (uint)1 << 7;
        const uint _Mobilize_Dirty_lblPictureName = (uint)1 << 8;
        const uint _Mobilize_Loaded_lblPictureName = (uint)1 << 8;
        const uint _Mobilize_Dirty_lblStock = (uint)1 << 9;
        const uint _Mobilize_Loaded_lblStock = (uint)1 << 9;
        const uint _Mobilize_Dirty_lblRestock = (uint)1 << 10;
        const uint _Mobilize_Loaded_lblRestock = (uint)1 << 10;
        const uint _Mobilize_Dirty_lblMaxstock = (uint)1 << 11;
        const uint _Mobilize_Loaded_lblMaxstock = (uint)1 << 11;
        const uint _Mobilize_Dirty_btnEditPage = (uint)1 << 12;
        const uint _Mobilize_Loaded_btnEditPage = (uint)1 << 12;
#line 11
    }
}