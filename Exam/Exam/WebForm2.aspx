<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Exam.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        <br />
            <asp:DropDownList runat="server" ID="dropDown">
                <asp:ListItem Text="Choose variant..." />
                <asp:ListItem Text="Country" />
                <asp:ListItem Text="Capital" />
                <asp:ListItem Text="Population" />
            </asp:DropDownList>
        <asp:Button Text="Calculate" id="calcBtn" runat="server" OnClick="calcBtn_Click" />
        <asp:Label Text="" ID="result" runat="server" />
    </div>
    </form>
</body>
</html>
