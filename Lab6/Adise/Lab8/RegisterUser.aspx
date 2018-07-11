<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs"
    Inherits="lab7b.RegisterUser" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Εγγραφη χρηστη"></asp:Label>
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow>
                    <asp:TableCell>Ονομα:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="NameTB" runat="server"></asp:TextBox></asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Δωστε ονομα!"
                            ControlToValidate="NameTB"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Επωνυμο:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="LNameTB" runat="server"></asp:TextBox></asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Δωστε Επωνυμο!"
                            ControlToValidate="LNameTB"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Email:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="EmailTB" runat="server"></asp:TextBox></asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Δωστε email" ControlToValidate="EmailTB"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Δωστε σωστο mail!"
                            ControlToValidate="EmailTB" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Username:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="UserNameTB" runat="server"></asp:TextBox></asp:TableCell><asp:TableCell>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Δωστε username!" ControlToValidate="UsernameTB"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Password:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="PasswordTB" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell><asp:TableCell>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Δωστε password!" ControlToValidate="PasswordTB"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Επιβεβαιωση password:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="ConfPassTB" runat="server" TextMode="Password"></asp:TextBox></asp:TableCell><asp:TableCell>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Ξαναδωστε password!" ControlToValidate="ConfPassTB"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Επιβεβαιωστε σωστα το password"
                                ControlToValidate="ConfPassTB" ControlToCompare="PasswordTB"></asp:CompareValidator>
                        </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Διευθυνση:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="AddressTB" runat="server"></asp:TextBox></asp:TableCell><asp:TableCell>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Δωστε διευθυνση!" ControlToValidate="AddressTB"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Τηλεφωνο επικοινωνιας:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="PhoneTB" runat="server"></asp:TextBox></asp:TableCell><asp:TableCell>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Δωστε τηλεφωνο!"
                                ControlToValidate="PhoneTB"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>ΤΚ:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TkTB" runat="server"></asp:TextBox></asp:TableCell><asp:TableCell>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Δωστε ΤΚ!" ControlToValidate="TkTB"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Πολη:</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="CityTB" runat="server"></asp:TextBox></asp:TableCell><asp:TableCell>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Δωστε πολη!" ControlToValidate="CityTB"></asp:RequiredFieldValidator>
                        </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Χωρα:</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem>Ελλαδα</asp:ListItem>
                            <asp:ListItem>ΗΠΑ</asp:ListItem>
                            <asp:ListItem>Αγγλια</asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Επιλεξτε χωρα!" ControlToValidate="DropDownList2"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="GendreLB" runat="server" Text="Φυλλο:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Ανδρας" GroupName="Sex" /><asp:RadioButton
                            ID="RadioButton2" runat="server" GroupName="Sex" Text="Γυναικα" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="AcceptLB" runat="server" Text="Αποδοχη Ορων:"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:CheckBox ID="AcceptCB" runat="server" />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell></asp:TableCell>
                    <asp:TableCell>
                        <asp:Button ID="SignUpB" runat="server" Text="Εγγραφη" OnClick="Sign_Up" /></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </asp:Panel>
        <asp:Panel ID="Panel2" Visible="false" runat="server">
            <asp:Table ID="Table2" runat="server">
                <asp:TableRow>
                    <asp:TableCell>Ονομα:</asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="P2NameTB" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Επωνυμο:</asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="P2LNameTB" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Email:</asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="P2MailTB" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Διευθυνση:</asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="P2AdrressTB" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Τηλεφωνο επικοινωνιας:</asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="P2PhoneTB" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>ΤΚ:</asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="P2TkTB" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Πολη:</asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="P2CityTB" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Χωρα:</asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="P2CountryTB" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Φυλλο:</asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="P2SexTB" runat="server"></asp:TextBox></asp:TableCell></asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Αποδοχη τιμων:</asp:TableCell><asp:TableCell>
                        <asp:Button ID="P2ConfButton" runat="server" Text="Ok" /></asp:TableCell></asp:TableRow>
            </asp:Table>
        </asp:Panel>
    </div>
</asp:Content>
