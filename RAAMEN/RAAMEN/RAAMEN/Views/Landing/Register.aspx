<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Landing.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RAAMEN.Views.Landing.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>REGISTER</h3>

    <div>
        <asp:Label ID="UsernameLabel" runat="server" Text="Username: "></asp:Label>
        <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="EmailLabel" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="GenderLabel" runat="server" Text="Gender: "></asp:Label>
        <asp:DropDownList ID="GenderDropDown" runat="server">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div>
        <asp:Label ID="PasswordLabel" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="ConfirmPasswordLabel" runat="server" Text="Confirm Password: "></asp:Label>
        <asp:TextBox ID="ConfirmTextBox" runat="server" TextMode="Password"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="ErrorLabel" runat="server"></asp:Label>
    </div>

    <div>
        <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
    </div>
</asp:Content>