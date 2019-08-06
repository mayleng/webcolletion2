<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="URL.aspx.cs" Inherits="WebCollection.URL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="参数一" OnClick="Button1_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="参数二" OnClick="Button2_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="参数三" OnClick="Button3_Click" />&nbsp;&nbsp;<br />
        <br />
        <br />
&nbsp;<asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="返回" />
    </form>
</body>
</html>
