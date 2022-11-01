<%@ Page Title="Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="eShopLegacyWebForms.Catalog.Details" %>

<asp:Content ID="Details" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="esh-body-title">Details</h2>

    <div class="container">
        <div class="row">
            <asp:Image ID="imgPicture" runat="server" CssClass="col-md-6 esh-picture" />
            <dl class="col-md-6 dl-horizontal">
                <dt>Name
                </dt>

                <dd>
                    <asp:Label ID="lblName" runat="server" />
                </dd>

                <dt>Description
                </dt>

                <dd>
                    <asp:Label ID="lblDescription" runat="server" />
                </dd>

                <dt>Brand
                </dt>

                <dd>
                    <asp:Label ID="lblBrand" runat="server" />
                </dd>

                <dt>Type
                </dt>

                <dd>
                    <asp:Label ID="lblType" runat="server" />
                </dd>
                <dt>Price
                </dt>

                <dd>
                    <asp:Label ID="lblPrice" CssClass="esh-price" runat="server" />
                </dd>

                <dt>Picture name
                </dt>

                <dd>
                    <asp:Label ID="lblPictureName" runat="server" />
                </dd>

                <dt>Stock
                </dt>

                <dd>
                    <asp:Label ID="lblStock" runat="server" />
                </dd>

                <dt>Restock
                </dt>

                <dd>
                    <asp:Label ID="lblRestock" runat="server" />
                </dd>

                <dt>Max stock
                </dt>

                <dd>
                    <asp:Label ID="lblMaxstock" runat="server" />
                </dd>

            </dl>
        </div>

        <div class="form-actions no-color esh-link-list">
            <asp:HyperLink ID="btnEditPage" runat="server" NavigateUrl="~/Catalog/Edit.aspx" CssClass="esh-link-item" Text="Edit" />            
            |
            <a runat="server" href="~/Home.aspx" class="esh-link-item">Back to list
            </a>
        </div>

    </div>
</asp:Content>
