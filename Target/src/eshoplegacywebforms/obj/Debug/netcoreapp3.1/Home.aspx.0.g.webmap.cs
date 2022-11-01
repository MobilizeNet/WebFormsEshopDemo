#pragma warning disable
#line 1 "Home.aspx.cs"
#line hidden
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Services;
using eShopLegacyWebForms.ViewModel;
using System;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms
{
    public partial class Home
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[4];
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Model) > 0)
            {
                yield return "Model";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnCreateNew) > 0)
            {
                yield return "btnCreateNew";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productList) > 0)
            {
                yield return "productList";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "CatalogService":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogService) > 0;
                case "Model":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Model) > 0;
                case "btnCreateNew":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnCreateNew) > 0;
                case "productList":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_productList) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["CatalogService"] = _Mobilize_References[0];
            refs["Model"] = _Mobilize_References[1];
            refs["btnCreateNew"] = _Mobilize_References[2];
            refs["productList"] = _Mobilize_References[3];
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
            var ref_Model = (Mobilize.WebMap.Common.Core.IObservable)this.Model;
            if (ref_Model != null)
                yield return ref_Model;
            var ref_btnCreateNew = (Mobilize.WebMap.Common.Core.IObservable)this.btnCreateNew;
            if (ref_btnCreateNew != null)
                yield return ref_btnCreateNew;
            var ref_productList = (Mobilize.WebMap.Common.Core.IObservable)this.productList;
            if (ref_productList != null)
                yield return ref_productList;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_CatalogService = (uint)1 << 0;
        const uint _Mobilize_Loaded_CatalogService = (uint)1 << 0;
        const uint _Mobilize_Dirty_Model = (uint)1 << 1;
        const uint _Mobilize_Loaded_Model = (uint)1 << 1;
        const uint _Mobilize_Dirty_btnCreateNew = (uint)1 << 2;
        const uint _Mobilize_Loaded_btnCreateNew = (uint)1 << 2;
        const uint _Mobilize_Dirty_productList = (uint)1 << 3;
        const uint _Mobilize_Loaded_productList = (uint)1 << 3;
#line 12
    }
}