<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Lab6.Products" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ID" DataSourceID="AccessDataSource1">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ID" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" 
                DataNavigateUrlFormatString="Products.aspx?id={0}" DataTextField="Name" 
                DataTextFormatString="{0}" HeaderText="Κατηγοριες Βιβλιων" />
        </Columns>
    </asp:GridView>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="~/App_Data/ebookstoredb.mdb" SelectCommand="SELECT * FROM [category]">
    </asp:AccessDataSource>
    <asp:AccessDataSource ID="AccessDataSource2" runat="server" 
        DataFile="~/App_Data/ebookstoredb.mdb" 
        
        SelectCommand="SELECT [Title], [Price], [ID] FROM [product] WHERE ([Category] = ?)">
        <SelectParameters>
            <asp:QueryStringParameter Name="Category" QueryStringField="id" Type="Int32" />
        </SelectParameters>
    </asp:AccessDataSource>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ID" DataSourceID="AccessDataSource2" 
        onselectedindexchanged="GridView2_SelectedIndexChanged" Width="105px">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="ID" 
                DataNavigateUrlFormatString="ProductInfo.aspx?id={0}" DataTextField="Title" 
                DataTextFormatString="{0}" HeaderText="Title" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        </Columns>
    </asp:GridView>
    
</asp:Content>
