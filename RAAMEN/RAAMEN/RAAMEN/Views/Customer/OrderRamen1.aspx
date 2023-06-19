<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Customer.Master" AutoEventWireup="true" CodeBehind="OrderRamen1.aspx.cs" Inherits="RAAMEN.Views.Customer.OrderRamen1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="RamenGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Ramen Name" SortExpression="Name" />
                <asp:BoundField DataField="Meatid" HeaderText="Meat ID" SortExpression="Meatid" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" SortExpression="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                <asp:ButtonField ButtonType="Button" CommandName="AddToCart" HeaderText="Action" ShowHeader="True" Text="Add To Cart" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>