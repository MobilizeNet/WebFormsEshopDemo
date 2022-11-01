#pragma warning disable
#line 1 "Services\\CatalogServiceMock.cs"
#line hidden
using eShopLegacyWebForms.Models;
using eShopLegacyWebForms.Models.Infrastructure;
using eShopLegacyWebForms.ViewModel;
using System.Collections.Generic;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms.Services
{
    public partial class CatalogServiceMock : Mobilize.WebMap.Common.Core.IObservable, Mobilize.WebMap.Common.Core.IDelta
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[1];
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
            refs["catalogItems"] = _Mobilize_References[0];
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
            var ref_catalogItems = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetAsObservable(this.catalogItems);
            if (ref_catalogItems != null)
                yield return ref_catalogItems;
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
            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_catalogItems) > 0)
            {
                yield return "catalogItems";
            }

            yield break;
        }

        protected virtual bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "catalogItems":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_catalogItems) > 0;
            }

            return false;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_catalogItems = (uint)1 << 0;
        const uint _Mobilize_Loaded_catalogItems = (uint)1 << 0;
#line 13
    }
}