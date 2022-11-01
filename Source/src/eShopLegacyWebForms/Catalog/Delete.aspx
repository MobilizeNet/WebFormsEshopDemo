<%@ Page Title="Delete" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="eShopLegacyWebForms.Catalog.Delete" %>

<asp:Content ID="Delete" ContentPlaceHolderID="MainContent" runat="server">

    <h2 class="esh-body-title">Delete</h2>

    <div class="container">
        <h3>Are you sure you want to delete this?</h3>
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

                <dt></dt>

                <dd class="esh-button-actions">
                    <a runat="server" href="~/Home.aspx" class="btn esh-button esh-button-secondary">[ Cancel ]
                    </a>
                    <asp:Button ID="btnDelete" CssClass="btn esh-button esh-button-primary" runat="server" Text="[ Delete ]" OnClick="Delete_Click" />
                </dd>
            </dl>
        </div>
    </div>
</asp:Content>
