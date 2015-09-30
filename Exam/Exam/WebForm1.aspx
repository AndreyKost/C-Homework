<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Exam.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <asp:Label Text="" runat="server" ID="onLoad" />
        <br />
            <asp:Label Text="Country" runat="server" />
            <br />
            <asp:TextBox runat="server" ID="countrylText"  />
            <br />
            <br />
            <asp:Label Text="Capital" runat="server" />
            <br />
            <asp:TextBox runat="server" ID="capitalText" />
            <br />
            <br />
            <asp:Label Text="Population" runat="server"  />
            <br />
            <asp:TextBox runat="server" ID="populationText" TextMode="Number"   />
            <br />
            <asp:Button Text="Add" runat="server" ID="add" OnClick="add_Click" />
            <br />  
        <asp:Button Text="OtherWeb" runat="server" ID="Button2" OnClick="secondClick" />
            <br />     
     
    </div>
    </form>
</body>
</html>
