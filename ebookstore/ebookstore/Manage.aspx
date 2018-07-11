<%@ Page Language="C#" MasterPageFile="~/MyFirst.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="ebookstore.Manage" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftcontent" runat="server">
<p>
    manage.aspx
</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
<p>
    This is  a page that provides management options for admin
</p>


    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="CategoryView" runat="server">
            <asp:GridView ID="KathgoriaGv" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="ID" DataSourceID="AccessDataSource1" Width="179px">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                ReadOnly="True" SortExpression="ID" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" 
                DataNavigateUrlFormatString="AdminProducts.aspx?=id={0}" DataTextField="Name" 
                DataTextFormatString="Des kathgoria {0}" HeaderText="Kathgories Bibliwn" />
        </Columns>
    </asp:GridView>

    <asp:AccessDataSource ID="AccessDataSource1" runat="server" 
        DataFile="bookstoreDataBase.mdb" SelectCommand="SELECT * FROM [category]">
    </asp:AccessDataSource>
        </asp:View>
        <asp:View ID="ProductsView" runat="server">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        
        </asp:View>
        
        
    </asp:MultiView>
    

</asp:Content>
