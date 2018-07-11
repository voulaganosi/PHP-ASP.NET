<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs"
    Inherits="Lab6.Login" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Visible="true">
    <asp:Label ID="ErrorMSG" runat="server"></asp:Label><br />
    <asp:Label ID="UserNameLb" runat="server" Text="UserName:"></asp:Label>
    <asp:TextBox ID="UserNameTB" runat="server"></asp:TextBox><br />
    <asp:Label ID="PassLb" runat="server" Text="Password:  "></asp:Label>
    <asp:TextBox ID="PasswordTB" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:Button ID="LoginB" runat="server" Text="Login" OnClick="LoginB_Click" />
    <br />
    Ξεχασατε τον κωδικο σας? Πατηστε <asp:LinkButton ID="ForgotLink" runat="server" 
            onclick="ForgotLink_Click">Εδω</asp:LinkButton> 
&nbsp;για να το στειλουμε στο email σας<br />
    Δεν εχετε εγγραφη? Πατησε
    <asp:LinkButton ID="SignUpLink" runat="server" onclick="SignUpLink_Click">Εδω</asp:LinkButton>
&nbsp;για εγγραφη
  </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Visible="false">
    Αποστολη συνθιματικου χρηστη<br />
    Email: 
        <asp:TextBox ID="MailTB" runat="server"></asp:TextBox><br /> 
        <asp:Button ID="MailButton" runat="server" Text="Αποστολη" />
    </asp:Panel>
</asp:Content>
