<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Staff.Master" AutoEventWireup="true" CodeBehind="ManageRamen1.aspx.cs" Inherits="RAAMEN.Views.Staff.ManageRamen1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="ManageRamenGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="ManageRamenGridView_RowDeleting" OnRowEditing="ManageRamenGridView_RowEditing">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Ramen ID" SortExpression="id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Meatid" HeaderText="Meat ID" SortExpression="Meatid" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" SortExpression="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="InsertButton" runat="server" Text="Insert New Ramen" OnClick="InsertButton_Click" />
    </div>
</asp:Content>