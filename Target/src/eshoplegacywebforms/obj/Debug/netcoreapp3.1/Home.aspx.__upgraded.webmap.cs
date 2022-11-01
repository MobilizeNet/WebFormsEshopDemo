#pragma warning disable
#line 1 "Home.aspx.__upgraded.cs"
#pragma warning disable
#line 1 "Home.aspx.__upgraded.cs"
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace eShopLegacyWebForms
{

   public partial class Home
   {

      private void ____Initialize_HeaderStyle0(Mobilize.Web.UI.Controls.TableItemStyle ___style)
      {
         ___style.CssClass = "esh-table-header";
      }

      private Mobilize.Web.UI.Controls.Image ___Build__Control4()
      {
         Mobilize.Web.UI.Controls.Image Image = new Mobilize.Web.UI.Controls.Image();
         Image.Name = "aspimage";
         Image.ImageUrl = $"/Pics/{this.Eval("PictureFileName")}";
         Image.CssClass = "esh-thumbnail";
         return Image;
      }

      private void ___Template__Control3(Mobilize.Web.UI.Controls.Control __cntrl)
      {
         __cntrl.Controls.Add(this.___Build__Control4());
      }

      private Mobilize.Web.UI.Controls.TemplateField ___Build__Control2()
      {
         Mobilize.Web.UI.Controls.TemplateField TemplateField = new Mobilize.Web.UI.Controls.TemplateField();
         TemplateField.HeaderText = "Picture";
         TemplateField.ItemTemplate = new Mobilize.Web.UI.CompiledBindableTemplateBuilder(new Mobilize.Web.UI.BuildTemplateMethod(this.___Template__Control3), null);
         return TemplateField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control5()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.DataField = "Name";
         BoundField.HeaderText = "Name";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control6()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.DataField = "Description";
         BoundField.HeaderText = "Description";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control7()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.DataField = "CatalogBrand.Brand";
         BoundField.HeaderText = "Brand";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control8()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.DataField = "CatalogType.Type";
         BoundField.HeaderText = "Type";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control9()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.DataField = "Price";
         BoundField.HeaderText = "Price";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control10()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.DataField = "PictureFileName";
         BoundField.HeaderText = "Picture name";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control11()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.DataField = "AvailableStock";
         BoundField.HeaderText = "Stock";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control12()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.DataField = "RestockThreshold";
         BoundField.HeaderText = "Restock";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.BoundField ___Build__Control13()
      {
         Mobilize.Web.UI.Controls.BoundField BoundField = new Mobilize.Web.UI.Controls.BoundField();
         BoundField.DataField = "MaxStockThreshold";
         BoundField.HeaderText = "Max stock";
         return BoundField;
      }

      private Mobilize.Web.UI.Controls.HyperLink ___Build__Control16()
      {
         Mobilize.Web.UI.Controls.HyperLink HyperLink = new Mobilize.Web.UI.Controls.HyperLink();
         HyperLink.Name = "btnEdit";
         HyperLink.NavigateUrl = $"eShopLegacyWebForms.Catalog.Edit?Id={this.Eval("Id")}";
         HyperLink.CssClass = "esh-table-link";
         HyperLink.Text = "Edit";
         return HyperLink;
      }

      private Mobilize.Web.UI.Controls.HyperLink ___Build__Control17()
      {
         Mobilize.Web.UI.Controls.HyperLink HyperLink = new Mobilize.Web.UI.Controls.HyperLink();
         HyperLink.Name = "btnDetails";
         HyperLink.NavigateUrl = $"eShopLegacyWebForms.Catalog.Details?Id={this.Eval("Id")}";
         HyperLink.CssClass = "esh-table-link";
         HyperLink.Text = "Details";
         return HyperLink;
      }

      private Mobilize.Web.UI.Controls.HyperLink ___Build__Control18()
      {
         Mobilize.Web.UI.Controls.HyperLink HyperLink = new Mobilize.Web.UI.Controls.HyperLink();
         HyperLink.Name = "btnDelete";
         HyperLink.NavigateUrl = $"eShopLegacyWebForms.Catalog.Delete?Id={this.Eval("Id")}";
         HyperLink.CssClass = "esh-table-link";
         HyperLink.Text = "Delete";
         return HyperLink;
      }

      private void ___Template__Control15(Mobilize.Web.UI.Controls.Control __cntrl)
      {
         __cntrl.Controls.Add(this.___Build__Control16());
         __cntrl.Controls.Add(this.___Build__Control17());
         __cntrl.Controls.Add(this.___Build__Control18());
      }

      private Mobilize.Web.UI.Controls.TemplateField ___Build__Control14()
      {
         Mobilize.Web.UI.Controls.TemplateField TemplateField = new Mobilize.Web.UI.Controls.TemplateField();
         TemplateField.HeaderText = "Options";
         TemplateField.ItemTemplate = new Mobilize.Web.UI.CompiledBindableTemplateBuilder(new Mobilize.Web.UI.BuildTemplateMethod(this.___Template__Control15), null);
         return TemplateField;
      }

      private void ___Build__GridColumns1(Mobilize.Web.UI.Controls.DataControlFieldCollection lst__cntrl)
      {
         lst__cntrl.Add(this.___Build__Control2());
         lst__cntrl.Add(this.___Build__Control5());
         lst__cntrl.Add(this.___Build__Control6());
         lst__cntrl.Add(this.___Build__Control7());
         lst__cntrl.Add(this.___Build__Control8());
         lst__cntrl.Add(this.___Build__Control9());
         lst__cntrl.Add(this.___Build__Control10());
         lst__cntrl.Add(this.___Build__Control11());
         lst__cntrl.Add(this.___Build__Control12());
         lst__cntrl.Add(this.___Build__Control13());
         lst__cntrl.Add(this.___Build__Control14());
      }

      private void ____Initialize_PagerStyle19(Mobilize.Web.UI.Controls.TableItemStyle ___style)
      {
         ___style.HorizontalAlign = Mobilize.Web.UI.Controls.HorizontalAlign.Center;
      }

      private void ____Initialize_RowStyle20(Mobilize.Web.UI.Controls.TableItemStyle ___style)
      {
         ___style.HorizontalAlign = Mobilize.Web.UI.Controls.HorizontalAlign.Center;
      }

   }

}
#pragma warning restore
