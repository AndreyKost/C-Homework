<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForms1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homework7</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label Text="UserName" runat="server" ID="Label1" /> <asp:TextBox runat="server"  ID="TextBox1" />    
       <p> <asp:Label Text="Password" runat="server" ID="Label2"  /> <asp:TextBox runat="server" ID="TextBox2" TextMode="Password" PasswordChar="*" MaxLength="10"/> </p>
        <p>
            <asp:Label Text="Repeat Password" runat="server" ID="Label3"/> <asp:TextBox runat="server" ID="TextBox3" TextMode="Password" PasswordChar="*" MaxLength="10"/> </p>
        <p>
            <asp:Label Text="Age " runat="server" ID="Label4"/><asp:TextBox runat="server" ID="TextBox4"/> </p>
        <p>
            <asp:Label Text="E-mail" runat="server" ID="label5" /><asp:TextBox runat="server" ID="TextBox5"/> </p>


        
        <p>
            <asp:Button Text="Register" runat="server" ID="Button1" OnClick="Button1_Click" Enabled="true"/> </p>
        
         </div>
    </form>
</body>
</html>
