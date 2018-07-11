<%@ Page Language="C#" MasterPageFile="~/MyFirst.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs"
    Inherits="ebookstore.Login" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftcontent" runat="server">
   <asp:Label ID="ErrMsg" runat="server" Text=""></asp:Label>
 <p>login aspx</p>
    &nbsp;
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <table>
                    
                    <asp:View ID="InfoView" runat="server">
                        <tr>
                            <td>
                                Onoma Xrhsth
                            </td>
                            <td>
                                <asp:TextBox ID="UserNameTB" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Kwdikos
                            </td>
                            <td>
                                <asp:TextBox ID="PasswordTB" runat="server" TextMode="Password"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="LoginSubmitB" runat="server" Text="Eisodos" OnClick="LoginSubmitB_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <br />
                                <span>ksexasate to kwdiko sas.Pathste</span><asp:LinkButton ID="ForgetPswd_Lb" runat="server"
                                    OnClick="ForgetPswd_Lb_Click">Edw</asp:LinkButton><span>gia na to steiloume sto mail
                                        sas</span><br />
                                <br />
                                <span>den exete eggrafei</span><asp:LinkButton ID="RegLink" runat="server" OnClick="RegLink_Click">Pathste edw gia egggrafh</asp:LinkButton>
                            </td>
                        </tr>
                    </asp:View>
                    <tr>
                        <td>
                            <asp:View ID="ForgetPassView" runat="server">
                                <asp:Label ID="EmailL" runat="server" Text="Email : "></asp:Label>
                                <asp:TextBox ID="EmailTB" runat="server" Width="444px"></asp:TextBox>
                                <asp:Button ID="SendB" runat="server" Text="Apostolh" />
                                <asp:Button ID="BackB" runat="server" Text="Pisw" OnClick="BackB_Click" />
                            </asp:View>
                            <asp:View ID="RegisterView" runat="server">
                                <asp:Label ID="NameL" runat="server" Text="Onoma"></asp:Label>
                                <asp:TextBox ID="NameTB" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="LastnameL" runat="server" Text="Epitheto"></asp:Label>
                                <asp:TextBox ID="LastnameTB" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="UsernameL" runat="server" Text="Username"></asp:Label>
                                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="PasswordL" runat="server" Text="Password"></asp:Label>
                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="ConfPassL" runat="server" Text="Epibebaiwsh password"></asp:Label>
                                <asp:TextBox ID="ConfPassTB" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="AdressL" runat="server" Text="dieuthinsh"></asp:Label>
                                <asp:TextBox ID="AdressTB" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="PhoneL" runat="server" Text="Thlefwno Epikoinwnias"></asp:Label>
                                <asp:TextBox ID="PhoneTB" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="TKL" runat="server" Text="Taxydrromikos Kwdikas"></asp:Label>
                                <asp:TextBox ID="TKTB" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:Label ID="CityL" runat="server" Text="City"></asp:Label>
                                <asp:TextBox ID="CityTB" runat="server"></asp:TextBox>
                                <br />
                                <br />
                                <asp:DropDownList ID="CountryList" runat="server">
                                    <asp:ListItem Selected="True">parakalw epilekste xwra</asp:ListItem>
                                    <asp:ListItem Value="Ellada">Ellada</asp:ListItem>
                                    <asp:ListItem Value="Usa">Amerikh</asp:ListItem>
                                    <asp:ListItem Value="Japan">Iapwnia</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <br />
                                <asp:Label ID="SexL" runat="server" Text="Fylo"></asp:Label>&nbsp &nbsp
                                <asp:RadioButton ID="ManRB" Text="Andras" runat="server" />
                                <asp:RadioButton ID="WomanRB" Text="Gynaika" runat="server" />
                                <br />
                                <br />
                                <asp:CheckBox ID="AcceptCheckBox" Text="apodexomai tous orous" runat="server" />
                                <br />
                                <br />
                                <asp:Button ID="RegB" runat="server" Text="Eggrafh" OnClick="RegB_Click" />
                            </asp:View>
                            <asp:View ID="ShowData" runat="server">
                                data
                            </asp:View>
                        </td>
                    </tr>
                </table>
            </asp:MultiView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
