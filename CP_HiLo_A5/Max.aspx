<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Max.aspx.cs" Inherits="CP_HiLo_A5.Max" %>

<!DOCTYPE html>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET Hi_Lo Game</title>
</head>
 <body bgcolor="#B6D9FA">
    <form id="form1" runat="server">
    <div>

        &nbsp;&nbsp;&nbsp;
      <b> <asp:Label ID="buttonPrompt" runat="server" Font-Names="Tahoma" 
            Font-Size="Small"></asp:Label></b> 
            &nbsp;<br />
            &nbsp;
    
        <asp:Button ID="magicButton" runat="server" Text="Enter" 
            onclick="max_Click" BackColor="#F8F1F0" Font-Bold="True" 
            ForeColor="Blue" />

        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ioBox" runat="server" Width="194px" ></asp:TextBox>

        <b><asp:RequiredFieldValidator ID="ioBoxValidator" runat="server"  
            BackColor="#FFFF99" BorderStyle="Outset" ControlToValidate="ioBox" 
            ErrorMessage="&quot;Sorry, this field is required&quot;" Font-Names="Calibri" 
            Height="16px" Width="787px" ForeColor="Red"></asp:RequiredFieldValidator></b>
        <br />

       <b> <asp:RangeValidator ID="ioBoxValidator2" runat="server" 
           BackColor="#FFFF99" BorderStyle="Outset" ControlToValidate="ioBox" 
           ErrorMessage="Please enter a max value (integer) from 1 to 2,147,483,647 " MaximumValue="2147483647"  
           MinimumValue="1" Type="Integer" Font-Names="Calibri" Height="16px" Width="787px" ForeColor="Red">
           </asp:RangeValidator></b>    
        <br />
       
        </div>
        
    </form>

</body>

</html>



