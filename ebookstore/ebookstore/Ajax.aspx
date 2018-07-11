<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ajax.aspx.cs" Inherits="ebookstore.Ajax" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color:Gray">
        Mesa sto div emperiexetai enas script manager o opoios kanei diaxeirhsh tou script xwris emeis na xreiastei na kanoume kati
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>  
        <asp:UpdateProgress ID="UpdateProgress1" runat="server" 
            AssociatedUpdatePanelID="UpdatePanel1" DisplayAfter="100">
            <ProgressTemplate>Fwrtonei</ProgressTemplate>
        </asp:UpdateProgress>
        
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Time_InsideL" runat="server" Text=""></asp:Label>
                <asp:Button ID="ShowTime_InsideB" runat="server" Text="wra" 
                    onclick="ShowTime_InsideB_Click" /> 
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    
    <div>
        <asp:Label ID="Time_OutsideL" runat="server" Text=""></asp:Label>
                <asp:Button ID="ShowTime_OutsideB" runat="server" Text="wra" 
            onclick="ShowTime_OutsideB_Click" /> 
    </div>
    </form>
</body>
</html>
