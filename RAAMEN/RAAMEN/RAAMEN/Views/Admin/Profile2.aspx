<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Admin.Master" AutoEventWireup="true" CodeBehind="Profile2.aspx.cs" Inherits="RAAMEN.Views.Admin.Profile2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <label for="UsernameTextBox">Username:</label>
            <asp:TextBox ID="UsernameTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <label for="EmailTextBox">Email:</label>
            <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <label for="GenderTextBox">Gender:</label>
            <asp:DropDownList ID="GenderDropDown" runat="server"></asp:DropDownList>
        </div>

        <div>
            <label for="PasswordTextBox">Password:</label>
            <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="SaveButton" runat="server" Text="Save Profile" OnClick="SaveButton_Click"/>
            <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
        </div>
    </div>
</asp:Content>