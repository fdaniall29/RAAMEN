<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Landing.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RAAMEN.Views.Landing.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>LOGIN</h3>

    <div>
        <asp:Label ID="UsernameLabel" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="PasswordLabel" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
    </div>

    <div>
        <asp:CheckBox ID="RememberMe" runat="server" Text="Remember Me"/>
    </div>

    <div>
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
        <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
    </div>
</asp:Content>