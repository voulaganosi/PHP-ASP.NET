<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs"
    Inherits="Lab6.Login" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="ErrorMSG" runat="server"></asp:Label><br />
    <asp:Label ID="UserNameLb" runat="server" Text="UserName:"></asp:Label>
    <asp:TextBox ID="UserNameTB" runat="server"></asp:TextBox><br />
    <asp:Label ID="PassLb" runat="server" Text="Password:  "></asp:Label>
    <asp:TextBox ID="PasswordTB" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:Button ID="LoginB" runat="server" Text="Login" OnClick="LoginB_Click" />
</asp:Content>
