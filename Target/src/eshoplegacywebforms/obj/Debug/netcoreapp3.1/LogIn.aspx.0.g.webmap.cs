#pragma warning disable
#line 1 "LogIn.aspx.cs"
#line hidden
using System;
using Mobilize.WebMap.Common.Attributes;

namespace eShopLegacyWebForms
{
    public partial class LogIn
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

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_txtUsername) > 0)
            {
                yield return "txtUsername";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_txtPassword) > 0)
            {
                yield return "txtPassword";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnLogin) > 0)
            {
                yield return "btnLogin";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblErrorMessage) > 0)
            {
                yield return "lblErrorMessage";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "txtUsername":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_txtUsername) > 0;
                case "txtPassword":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_txtPassword) > 0;
                case "btnLogin":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_btnLogin) > 0;
                case "lblErrorMessage":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_lblErrorMessage) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            refs["txtUsername"] = _Mobilize_References[0];
            refs["txtPassword"] = _Mobilize_References[1];
            refs["btnLogin"] = _Mobilize_References[2];
            refs["lblErrorMessage"] = _Mobilize_References[3];
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

            var ref_txtUsername = (Mobilize.WebMap.Common.Core.IObservable)this.txtUsername;
            if (ref_txtUsername != null)
                yield return ref_txtUsername;
            var ref_txtPassword = (Mobilize.WebMap.Common.Core.IObservable)this.txtPassword;
            if (ref_txtPassword != null)
                yield return ref_txtPassword;
            var ref_btnLogin = (Mobilize.WebMap.Common.Core.IObservable)this.btnLogin;
            if (ref_btnLogin != null)
                yield return ref_btnLogin;
            var ref_lblErrorMessage = (Mobilize.WebMap.Common.Core.IObservable)this.lblErrorMessage;
            if (ref_lblErrorMessage != null)
                yield return ref_lblErrorMessage;
            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        private uint _Mobilize_LoadedFlag_0;
        const uint _Mobilize_Dirty_txtUsername = (uint)1 << 0;
        const uint _Mobilize_Loaded_txtUsername = (uint)1 << 0;
        const uint _Mobilize_Dirty_txtPassword = (uint)1 << 1;
        const uint _Mobilize_Loaded_txtPassword = (uint)1 << 1;
        const uint _Mobilize_Dirty_btnLogin = (uint)1 << 2;
        const uint _Mobilize_Loaded_btnLogin = (uint)1 << 2;
        const uint _Mobilize_Dirty_lblErrorMessage = (uint)1 << 3;
        const uint _Mobilize_Loaded_lblErrorMessage = (uint)1 << 3;
#line 9
    }
}