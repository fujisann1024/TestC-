<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="MultiApp.View.Test1_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" runat="server"></asp:Label><br />
            <asp:Label ID="result" runat="server"></asp:Label>
            <asp:Button ID="button1" runat="server" OnClick="button1_Click"/>
        </div>
    </form>
</body>
</html>
