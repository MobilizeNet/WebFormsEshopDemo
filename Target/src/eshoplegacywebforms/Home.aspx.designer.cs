using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. 
// </auto-generated>
//------------------------------------------------------------------------------

namespace eShopLegacyWebForms
{


    public partial class Home
   {

      public Home()
      {
         this.InitializeComponent();
      }

      /// <summary>
      /// btnCreateNew control.
      /// </summary>
      /// <remarks>
      /// Auto-generated field.
      /// To modify move field declaration from designer file to code-behind file.
      /// </remarks>
      [Intercepted]
      protected Mobilize.Web.UI.Controls.HtmlControls.HtmlAnchor btnCreateNew { get; set; }

      /// <summary>
      /// productList control.
      /// </summary>
      /// <remarks>
      /// Auto-generated field.
      /// To modify move field declaration from designer file to code-behind file.
      /// </remarks>
      [Intercepted]
      protected Mobilize.Web.UI.Controls.GridView productList { get; set; }

      private void InitializeComponent()
      {
         this.MasterPageFile = "eShopLegacyWebForms.SiteMaster";
         this.Name = "Home";
         this.btnCreateNew = new Mobilize.Web.UI.Controls.HtmlControls.HtmlAnchor();
         this.productList = new Mobilize.Web.UI.Controls.GridView();
         this.btnCreateNew.Name = "btnCreateNew";
         this.btnCreateNew.HRef = "eShopLegacyWebForms.Catalog.Create";
         this.productList.Name = "productList";
         this.productList.AutoGenerateColumns = false;
         this.productList.CssClass = "table";
         this.productList.EmptyDataText = "No data was returned.";
         this.productList.AllowPaging = true;
         this.productList.PageIndexChanging += new Mobilize.Web.UI.Controls.GridViewPageEventHandler(this.productList_PageIndexChanging);
         this.productList.PageSize = 8;
         this.____Initialize_HeaderStyle0(this.productList.HeaderStyle);
         this.___Build__GridColumns1(this.productList.Columns);
         this.____Initialize_PagerStyle19(this.productList.PagerStyle);
         this.____Initialize_RowStyle20(this.productList.RowStyle);
         this.Controls.Add(this.btnCreateNew);
         this.Controls.Add(this.productList);
      }
   }
}