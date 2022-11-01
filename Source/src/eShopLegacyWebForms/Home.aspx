<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="eShopLegacyWebForms.Home" %>

<asp:Content ID="CatalogList" ContentPlaceHolderID="MainContent" runat="server">

    <div class="esh-table">
        <p class="esh-link-wrapper">
            <a id="btnCreateNew" runat="server" href="~/Catalog/Create.aspx" class="btn esh-button esh-button-primary">Create New
            </a>
        </p>
        <asp:GridView ID="productList" runat="server" AutoGenerateColumns="false" CssClass="table" EmptyDataText="No data was returned." AllowPaging="True" OnPageIndexChanging="productList_PageIndexChanging" PageSize="8">
            <HeaderStyle CssClass="esh-table-header" />
            <Columns>
                <asp:TemplateField HeaderText="Picture">
                    <ItemTemplate>
                        <asp:Image runat="server" ID="aspimage" ImageUrl='<%# $"/Pics/{Eval("PictureFileName")}"%>' CssClass="esh-thumbnail" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
                <asp:BoundField DataField="CatalogBrand.Brand" HeaderText="Brand" />
                <asp:BoundField DataField="CatalogType.Type" HeaderText="Type" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:BoundField DataField="PictureFileName" HeaderText="Picture name" />
                <asp:BoundField DataField="AvailableStock" HeaderText="Stock" />
                <asp:BoundField DataField="RestockThreshold" HeaderText="Restock" />
                <asp:BoundField DataField="MaxStockThreshold" HeaderText="Max stock" />
                <asp:TemplateField HeaderText="Options">
                    <ItemTemplate>
                        <asp:HyperLink ID="btnEdit" NavigateUrl='<%# $"~/Catalog/Edit.aspx?Id={Eval("Id")}"%>' runat="server" CssClass="esh-table-link">
                            Edit
                        </asp:HyperLink>
                        |
                        <asp:HyperLink ID="btnDetails" NavigateUrl='<%# $"~/Catalog/Details.aspx?Id={Eval("Id")}"%>' runat="server" CssClass="esh-table-link">
                            Details
                        </asp:HyperLink>
                        |
                        <asp:HyperLink ID="btnDelete" NavigateUrl='<%# $"~/Catalog/Delete.aspx?Id={Eval("Id")}"%>' runat="server" CssClass="esh-table-link">
                            Delete
                        </asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerSettings Mode="NextPrevious" NextPageText="Next" PreviousPageText="Previous" />
            <PagerStyle HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" />
        </asp:GridView>
    </div>
</asp:Content>
