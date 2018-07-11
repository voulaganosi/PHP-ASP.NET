<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductInfo.aspx.cs" Inherits="Lab8.ProductInfo" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/ebookstoredb.mdb" 
        SelectCommand="SELECT * FROM [product] WHERE ([ID] = ?)">
        <SelectParameters>
            <asp:QueryStringParameter Name="ID" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:AccessDataSource>
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="206px" 
        AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="AccessDataSource1">
        <Fields>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
            <asp:BoundField DataField="Description" HeaderText="Description" 
                SortExpression="Description" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            <asp:BoundField DataField="Category" HeaderText="Category" 
                SortExpression="Category" />
        </Fields>
    </asp:DetailsView>
    <asp:Label ID="PosotitaLB" runat="server" Text="Ποσοτητα:"></asp:Label><asp:TextBox
        ID="PosotitaTB" runat="server">1</asp:TextBox><br />
    <asp:Button ID="ProsthikiB" runat="server" Text="Προσθηκη στο Καλαθι" 
        onclick="ProsthikiB_Click" />
</asp:Content>
