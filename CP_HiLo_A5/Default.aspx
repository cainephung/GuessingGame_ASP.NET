<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CP_HiLo_A5.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET Hi_Lo Game</title>
</head>
    
<body bgcolor="#B6D9FA">

    <form id="form1" runat="server">

    <div>
    
        &nbsp;&nbsp;&nbsp;
       <b><asp:Label ID="buttonPrompt" runat="server" Font-Names="Tahoma" 
            Font-Size="Small" Text="Please enter your name:">
          </asp:Label></b>
        &nbsp;<br />&nbsp;
    
        <asp:Button ID="magicButton" runat="server" Text="Enter" 
             BackColor="#F8F1F0" Font-Bold="True" 
            ForeColor="Blue" onclick="default_Click"/>

        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ioBox" runat="server" Width="194px" ></asp:TextBox>
        <b><asp:RequiredFieldValidator ID="ioBoxValidator" runat="server" 
            BackColor="#FFFF99" BorderStyle="Outset" ControlToValidate="ioBox" 
            ErrorMessage="&quot;Sorry, this field is required&quot;" Font-Names="Calibri" 
            Height="16px" Width="787px" ForeColor="Red"></asp:RequiredFieldValidator></b>
       
        </div>
       
    </form>
</body>

</html>
