<%@ Page Title="Edit" Language="C#" Debug="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" ValidateRequest="false" CodeBehind="Edit.aspx.cs" Inherits="eShopLegacyWebForms.Catalog.Edit" %>

<asp:Content ID="Edit" ContentPlaceHolderID="MainContent" runat="server">

    <h2 class="esh-body-title">Edit</h2>

    <div class="container">
        <div class="row">
            <asp:Image runat="server" CssClass="col-md-6 esh-picture" ID="img1" />
            <div class="col-md-6 form-horizontal">

                <div class="form-group">
                    <label class="control-label col-md-4">Name</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="txt_Name" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="NameValidator" runat="server" ControlToValidate="txt_Name" Display="Dynamic"
                            CssClass="field-validation-valid text-danger" ErrorMessage="The Name field is required." />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-4">Description</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Description" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-4">Brand</label>
                    <div class="col-md-8">
                        <asp:DropDownList ID="BrandDropDownList" runat="server"
                            DataTextField="Brand"
                            DataValueField="Id"
                            CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-4">Type</label>
                    <div class="col-md-8">
                        <asp:DropDownList ID="TypeDropDownList" runat="server"
                            DataTextField="Type"
                            DataValueField="Id"
                            CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-4">Price</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Price" runat="server" CssClass="form-control" ></asp:TextBox>
                        <asp:RangeValidator ID="PriceValidator" runat="server" ControlToValidate="Price" Type="Currency" CssClass="text-danger" Display="Dynamic"
                            MinimumValue="0" MaximumValue="1000000" ErrorMessage="The Price must be a positive number with maximum two decimals between 0 and 1 million." />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-4">Picture name</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="PictureFileName" runat="server" ToolTip="Not allowed for edition"
                            CssClass="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-4">Stock</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Stock" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RangeValidator ID="StockValidator" runat="server" ControlToValidate="Stock" Type="Integer" CssClass="text-danger" Display="Dynamic"
                            MinimumValue="0" MaximumValue="10000000" ErrorMessage="The field Stock must be between 0 and 10 million." />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-4">Restock</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Restock" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RangeValidator ID="RestockValidator" runat="server" ControlToValidate="Restock" Type="Integer" CssClass="text-danger" Display="Dynamic"
                            MinimumValue="0" MaximumValue="10000000" ErrorMessage="The field Restock must be between 0 and 10 million." />
                    </div>
                </div>

                <div class="form-group">
                    <label class="control-label col-md-4">Max stock</label>
                    <div class="col-md-8">
                        <asp:TextBox ID="Maxstock" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RangeValidator ID="MaxstockValidator" runat="server" ControlToValidate="Maxstock" Type="Integer" CssClass="text-danger" Display="Dynamic"
                            MinimumValue="0" MaximumValue="10000000" ErrorMessage="The field Max stock must be between 0 and 10 million." />
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-12 text-right esh-button-actions">
                        <a runat="server" href="~/Home.aspx" class="btn esh-button esh-button-secondary">[ Cancel ]
                        </a>
                        <asp:Button ID="btnSave" CssClass="btn esh-button esh-button-primary" runat="server" Text="[ Save ]" OnClick="Save_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
