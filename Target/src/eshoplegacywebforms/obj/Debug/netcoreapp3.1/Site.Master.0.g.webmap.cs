#pragma warning disable
#line 1 "Site.Master.cs"
#line hidden
using System;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace eShopLegacyWebForms
{
    public partial class SiteMaster
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier[] _Mobilize_References = new Mobilize.WebMap.Common.Core.Identifier[3];
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblUsername) > 0)
            {
                yield return "lblUsername";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnLogout) > 0)
            {
                yield return "btnLogout";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_MainContent) > 0)
            {
                yield return "MainContent";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "lblUsername":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblUsername) > 0;
                case "btnLogout":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnLogout) > 0;
                case "MainContent":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_MainContent) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["lblUsername"] = _Mobilize_References[0];
            refs["btnLogout"] = _Mobilize_References[1];
            refs["MainContent"] = _Mobilize_References[2];
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

            var ref_lblUsername = (Mobilize.WebMap.Common.Core.IObservable)this.lblUsername;
            if (ref_lblUsername != null)
                yield return ref_lblUsername;
            var ref_btnLogout = (Mobilize.WebMap.Common.Core.IObservable)this.btnLogout;
            if (ref_btnLogout != null)
                yield return ref_btnLogout;
            var ref_MainContent = (Mobilize.WebMap.Common.Core.IObservable)this.MainContent;
            if (ref_MainContent != null)
                yield return ref_MainContent;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_lblUsername = (uint)1 << 0;
        const uint _Mobilize_Loaded_lblUsername = (uint)1 << 0;
        const uint _Mobilize_Dirty_btnLogout = (uint)1 << 1;
        const uint _Mobilize_Loaded_btnLogout = (uint)1 << 1;
        const uint _Mobilize_Dirty_MainContent = (uint)1 << 2;
        const uint _Mobilize_Loaded_MainContent = (uint)1 << 2;
#line 10
    }
}