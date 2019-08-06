<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FanXing.aspx.cs" Inherits="WebCollection.FanXing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>默认进入本页，调用泛型方法</p>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="泛型参数" OnClick="Button1_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="泛型类" OnClick="FanxingClass" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="返回" OnClick="Button3_Click" />
        </p>
    </form>
</body>
</html>
