<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Staff.Master" AutoEventWireup="true" CodeBehind="Home2.aspx.cs" Inherits="RAAMEN.Views.Staff.Home2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
        <asp:DropDownList ID="GenderDropDown" runat="server"></asp:DropDownList>
    </div>

    <div>
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
    </div>
</asp:Content>