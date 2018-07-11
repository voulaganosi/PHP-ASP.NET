<%@ Page Language="C#" MasterPageFile="~/MyFirst.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
    Inherits="ebookstore.Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftcontent" runat="server">
    <p>Defaul aspx</p>
    <asp:MultiView ID="MultiView1" runat="server">
        <asp:View ID="PelathsView" runat="server">
            <ol id="ProductCategories">
        <li>
             <a href="Showcat.aspx?Category=Programming Languages"><asp:Literal ID="Cat1" runat="server" Text=" "></asp:Literal></a>
        </li>
        <li>
            <a href="Showcat.aspx?Category=Operating Systems"><asp:Literal ID="Cat2" runat="server" Text=""></asp:Literal></a>
        </li>
        <li>
            <a href="Showcat.aspx?Category=Databases"><asp:Literal ID="Cat3" runat="server" Text=""></asp:Literal></a>
        </li>
        <li>
            <a href="Showcat.aspx?Category=Networks"><asp:Literal ID="Cat4" runat="server" Text=""></asp:Literal></a>
        </li>
        <li>
             <a href="Showcat.aspx?Category=Web"><asp:Literal ID="Cat5" runat="server" Text=""></asp:Literal></a>
        </li>
    </ol>
        </asp:View>
        <asp:View ID="ManagementView" runat="server">
             <ol id="Ol1">
        <li>
             <a href="Manage.aspx?Epeks=Kathgories"><asp:Literal ID="M1" runat="server" Text="Diaxeirhsh Kathgoriwn"></asp:Literal></a>
        </li>
        <li>
            <a href="Manage.aspx?Epeks=Proionta"><asp:Literal ID="M2" runat="server" Text="Diaxeirhsh Proiontwn"></asp:Literal></a>
        </li>
        <li>
            <a href="Manage.aspx?Epeks=Paragkelies"><asp:Literal ID="M3" runat="server" Text="Diaxeirhsh Paragkeliwn"></asp:Literal></a>
        </li>
       
        
    </ol>
        </asp:View>
    </asp:MultiView>
    
   
    
    
    
   
 
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    ARXIKH SELIDA TOU EBOOKSTORE.HELLO WORLD
    <asp:Label ID="UserGreeting" runat="server" Text=""></asp:Label>
</asp:Content>
