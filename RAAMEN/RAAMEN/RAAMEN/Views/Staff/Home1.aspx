﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Staff.Master" AutoEventWireup="true" CodeBehind="Home1.aspx.cs" Inherits="RAAMEN.Views.Staff.Home1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="StaffGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="User ID" SortExpression="Id" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="Roleid" HeaderText="Role ID" SortExpression="Roleid" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>