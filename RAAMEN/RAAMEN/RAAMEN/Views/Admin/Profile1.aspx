<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Admin.Master" AutoEventWireup="true" CodeBehind="Profile1.aspx.cs" Inherits="RAAMEN.Views.Admin.Profile1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <label for="UsernameTextBox">Username:</label>
            <asp:TextBox ID="UsernameTextBox" runat="server" Enabled="false"></asp:TextBox>
        </div>

        <div>
            <label for="EmailTextBox">Email:</label>
            <asp:TextBox ID="EmailTextBox" runat="server" Enabled="false"></asp:TextBox>
        </div>

        <div>
            <label for="GenderTextBox">Gender:</label>
            <asp:TextBox ID="GenderTextBox" runat="server" Enabled="false"></asp:TextBox>
        </div>

        <div>
            <label for="PasswordTextBox">Password:</label>
            <asp:TextBox ID="PasswordTextBox" runat="server" Enabled="false"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="EditButton" runat="server" Text="Edit Profile" OnClick="EditButton_Click" />
        </div>
    </div>
</asp:Content>