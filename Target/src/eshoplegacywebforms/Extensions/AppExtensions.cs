
namespace eShopLegacyWebForms
{
    public static class AppExtensions
    {
        public static ExtApplication ExtApp(this Mobilize.WebMap.Common.DCP.IApplication app) => app as ExtApplication;
        public static ExtApplication ExtApp(this object obj) => Mobilize.Web.UI.Application.CurrentApplication as ExtApplication;
    }
}

