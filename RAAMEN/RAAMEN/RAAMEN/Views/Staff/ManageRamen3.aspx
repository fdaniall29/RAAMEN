<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Staff.Master" AutoEventWireup="true" CodeBehind="ManageRamen3.aspx.cs" Inherits="RAAMEN.Views.Staff.ManageRamen3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3>Insert New Ramen</h3>
        <div>
            <asp:Label ID="NameLabel" runat="server" Text="Ramen Name: "></asp:Label>
            <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="MeatLabel" runat="server" Text="Meat ID: "></asp:Label>
            <asp:DropDownList ID="MeatDropDown" runat="server"></asp:DropDownList>
        </div>

        <div>
            <asp:Label ID="BrothLabel" runat="server" Text="Broth: "></asp:Label>
            <asp:TextBox ID="BrothTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="PriceLabel" runat="server" Text="Price: "></asp:Label>
            <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="InsertButton" runat="server" Text="Insert Ramen" OnClick="InsertButton_Click" />
            <asp:Button ID="CancelButton" runat="server" Text="Cancel" OnClick="CancelButton_Click" />
        </div>
    </div>
</asp:Content>