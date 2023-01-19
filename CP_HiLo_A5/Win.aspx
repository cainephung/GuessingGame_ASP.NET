<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Win.aspx.cs" Inherits="CP_HiLo_A5.Win" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

 <body bgcolor="#0DFA43">

    <form id="form1" runat="server">
        <div style="margin-left: auto; margin-right: auto; text-align: center; vertical-align:central;">

        <b><asp:Label ID="buttonPrompt" runat="server" Font-Names="Tahoma" 
            Font-Size="Large">
          </asp:Label></b> &nbsp;<br />

            <asp:Button ID="magicButton" runat="server" Text=" Play Again" 
            onclick="reset_Click" BackColor="#F8F1F0" Font-Bold="True" 
            ForeColor="Blue" />
      
        </div>

    </form>

</body>

</html>
