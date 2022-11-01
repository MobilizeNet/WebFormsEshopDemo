<%@ Page Title="Log In" Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="eShopLegacyWebForms.LogIn" %>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title><%: Page.Title %> - Catalog manager (Web Forms)</title>

    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/base.css" rel="stylesheet" />
    <link href="css/custom.css" rel="stylesheet" />
    <link href="css/site.css" rel="stylesheet" />
</head>
<body>
    <div class="d-flex justify-content-center pt-5">

        <form runat="server" class="login-form">
            <h3 class="text-center mb-3">Log in</h3>
            <!-- Username input -->
            <div class="form-outline mb-4">
                <label class="form-label" for="txtUsername">Username</label>
                <asp:TextBox runat="server" ID="txtUsername" CssClass="form-control"></asp:TextBox>
            </div>

            <!-- Password input -->
            <div class="form-outline mb-4">
                <label class="form-label" for="txtPassword">Password</label>
                <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" TextMode="Password"></asp:TextBox>
            </div>

            <!-- Submit button -->
            <div class="form-outline mb-4">
                <asp:Button ID="btnLogin" runat="server" Text="Log in" OnClick="Login_Click" />
            </div>
            <asp:Label ID="lblErrorMessage" CssClass="error-message" Visible="false" runat="server" />
        </form>            
    </div>
</body>
</html>
