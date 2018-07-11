<%@ Page Language="C#" MasterPageFile="~/MyFirst.Master" AutoEventWireup="true" CodeBehind="Showcat.aspx.cs"
    Inherits="ebookstore.Showcat" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftcontent" runat="server">
    <asp:Label ID="CategoryL" runat="server" Text="Label"></asp:Label>
       <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="showCategory" runat="server">
                 
                    <asp:Table ID="ProductTable" runat="server">
                        <asp:TableRow>
                            <asp:TableCell>ID</asp:TableCell>
                            <asp:TableCell>Title</asp:TableCell>
                            <asp:TableCell>Description</asp:TableCell>
                            <asp:TableCell>Price</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:View>
                <asp:View ID="AddToCart" runat="server">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <p>
                        add</p>
                    <asp:Table ID="CartTable" runat="server">
                       
                        <asp:TableRow>
                            <asp:TableCell>ID</asp:TableCell>
                            <asp:TableCell>Title</asp:TableCell>
                            <asp:TableCell>Description</asp:TableCell>
                            <asp:TableCell>Price</asp:TableCell>
                            <asp:TableCell>
                                <asp:Label ID="PosotL" runat="server" Text=" "></asp:Label>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                   
                </asp:View>
            </asp:MultiView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
