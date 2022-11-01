#pragma warning disable
#line 1 "Models\\CatalogItem.cs"
#line hidden
using System.ComponentModel.DataAnnotations;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Models
{
    public partial class CatalogItem : Mobilize.WebMap.Common.Core.IObservable, Mobilize.WebMap.Common.Core.IDelta
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[2];
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier  _mobilizeId = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.IdentifierService.GetIdentifier();
        Mobilize.WebMap.Common.Core.Identifier Mobilize.WebMap.Common.Core.IObservable.MobilizeId
        {
            get =>  _mobilizeId;
            set =>  _mobilizeId = value;
        }

        Mobilize.WebMap.Common.Core.ReferenceMap Mobilize.WebMap.Common.Core.IObservable.References
        {
            get => this._Mobilize_GetReferenceMap(new Mobilize.WebMap.Common.Core.ReferenceMap());
            set => throw new System.NotImplementedException();
        }

        protected uint _Mobilize_ControlFlag = 1;
        bool Mobilize.WebMap.Common.Core.ITrackable.IsNew
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_IsNew_Flag) > 0;
            set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 0 : this._Mobilize_ControlFlag & 0 << 0;
        }

        Mobilize.WebMap.Common.Core.IDelta Mobilize.WebMap.Common.Core.ITrackable.Delta => this;
        void Mobilize.WebMap.Common.Core.ITrackable.CleanChanges() => _Mobilize_CleanChanges();
        protected virtual void _Mobilize_CleanChanges()
        {
            if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
            {
                this._Mobilize_DirtyFlag_0 = 0;
                this._Mobilize_LoadedFlag_0 = 0;
                this._Mobilize_ControlFlag = 0;
            }
        }

        protected virtual Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            refs["CatalogType"] = _Mobilize_References[0];
            refs["CatalogBrand"] = _Mobilize_References[1];
            return refs;
        }

        private int _Mobilize_RefCount = 0;
        int Mobilize.WebMap.Common.Core.IObservable.DecrementRefCount()
        {
            return System.Threading.Interlocked.Decrement(ref _Mobilize_RefCount);
        }

        int Mobilize.WebMap.Common.Core.IObservable.IncrementRefCount()
        {
            return System.Threading.Interlocked.Increment(ref _Mobilize_RefCount);
        }

        int Mobilize.WebMap.Common.Core.IObservable.RefCount
        {
            get
            {
                return _Mobilize_RefCount;
            }
        }

        System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> Mobilize.WebMap.Common.Core.IObservable.GetReferences()
        {
            return this._Mobilize_GetReferences();
        }

        protected virtual System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
        {
            var ref_CatalogType = (Mobilize.WebMap.Common.Core.IObservable)this.CatalogType;
            if (ref_CatalogType != null)
                yield return ref_CatalogType;
            var ref_CatalogBrand = (Mobilize.WebMap.Common.Core.IObservable)this.CatalogBrand;
            if (ref_CatalogBrand != null)
                yield return ref_CatalogBrand;
            yield break;
        }

        const uint _Mobilize_IsNew_Flag = (uint)1 << 0;
        protected const uint _Mobilize_HasChanged_Flag = (uint)1 << 1;
        bool Mobilize.WebMap.Common.Core.ITrackable.HasChanged
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_HasChanged_Flag) > 0;
        }

        const uint _Mobilize_IsRefresh_Flag = (uint)1 << 2;
        bool Mobilize.WebMap.Common.Core.ITrackable.IsRefresh
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_IsRefresh_Flag) > 0;
            set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 2 : this._Mobilize_ControlFlag & 0 << 2;
        }

        const uint _Mobilize_IsMarked_Flag = (uint)1 << 3;
        bool Mobilize.WebMap.Common.Core.ITrackable.IsMarked
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_IsMarked_Flag) > 0;
            set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 3 : this._Mobilize_ControlFlag & 0 << 3;
        }

        bool Mobilize.WebMap.Common.Core.IDelta.IsNew
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_IsNew_Flag) > 0;
            set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 0 : this._Mobilize_ControlFlag & 0 << 0;
        }

        Mobilize.WebMap.Common.Core.IObservable Mobilize.WebMap.Common.Core.IDelta.Target
        {
            get => this;
            set => throw new System.NotImplementedException();
        }

        System.Collections.Generic.IEnumerable<string> Mobilize.WebMap.Common.Core.IDelta.Changes => this._Mobilize_GetChanges();
        bool Mobilize.WebMap.Common.Core.IDelta.HasChanges(string propertyName) => this._Mobilize_HasChanges(propertyName);
        protected virtual System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Id) > 0)
            {
                yield return "Id";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Name) > 0)
            {
                yield return "Name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Description) > 0)
            {
                yield return "Description";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Price) > 0)
            {
                yield return "Price";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_PictureFileName) > 0)
            {
                yield return "PictureFileName";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_PictureUri) > 0)
            {
                yield return "PictureUri";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogTypeId) > 0)
            {
                yield return "CatalogTypeId";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogType) > 0)
            {
                yield return "CatalogType";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogBrandId) > 0)
            {
                yield return "CatalogBrandId";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogBrand) > 0)
            {
                yield return "CatalogBrand";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_AvailableStock) > 0)
            {
                yield return "AvailableStock";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_RestockThreshold) > 0)
            {
                yield return "RestockThreshold";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_MaxStockThreshold) > 0)
            {
                yield return "MaxStockThreshold";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_OnReorder) > 0)
            {
                yield return "OnReorder";
            }

            yield break;
        }

        protected virtual bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "Id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Id) > 0;
                case "Name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Name) > 0;
                case "Description":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Description) > 0;
                case "Price":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Price) > 0;
                case "PictureFileName":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_PictureFileName) > 0;
                case "PictureUri":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_PictureUri) > 0;
                case "CatalogTypeId":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogTypeId) > 0;
                case "CatalogType":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogType) > 0;
                case "CatalogBrandId":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogBrandId) > 0;
                case "CatalogBrand":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_CatalogBrand) > 0;
                case "AvailableStock":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_AvailableStock) > 0;
                case "RestockThreshold":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_RestockThreshold) > 0;
                case "MaxStockThreshold":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_MaxStockThreshold) > 0;
                case "OnReorder":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_OnReorder) > 0;
            }

            return false;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_Id = (uint)1 << 0;
        const uint _Mobilize_Dirty_Name = (uint)1 << 1;
        const uint _Mobilize_Dirty_Description = (uint)1 << 2;
        const uint _Mobilize_Dirty_Price = (uint)1 << 3;
        const uint _Mobilize_Dirty_PictureFileName = (uint)1 << 4;
        const uint _Mobilize_Dirty_PictureUri = (uint)1 << 5;
        const uint _Mobilize_Dirty_CatalogTypeId = (uint)1 << 6;
        const uint _Mobilize_Dirty_CatalogType = (uint)1 << 7;
        const uint _Mobilize_Loaded_CatalogType = (uint)1 << 0;
        const uint _Mobilize_Dirty_CatalogBrandId = (uint)1 << 8;
        const uint _Mobilize_Dirty_CatalogBrand = (uint)1 << 9;
        const uint _Mobilize_Loaded_CatalogBrand = (uint)1 << 1;
        const uint _Mobilize_Dirty_AvailableStock = (uint)1 << 10;
        const uint _Mobilize_Dirty_RestockThreshold = (uint)1 << 11;
        const uint _Mobilize_Dirty_MaxStockThreshold = (uint)1 << 12;
        const uint _Mobilize_Dirty_OnReorder = (uint)1 << 13;
#line 9
    }
}