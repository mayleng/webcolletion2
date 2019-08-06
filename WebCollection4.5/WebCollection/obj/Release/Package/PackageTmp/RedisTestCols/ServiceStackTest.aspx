<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServiceStackTest.aspx.cs" Inherits="WebCollection.RedisTestCols.ServiceStackTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ServiceStack.redis安装版本3.9.32
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="增加" OnClick="Button1_Click" />&nbsp;
            <asp:Button ID="Button3" runat="server" Text="查询" OnClick="Button3_Click" />&nbsp;
            <asp:Button ID="Button5" runat="server" Text="加一" OnClick="Button5_Click" />&nbsp;
            <asp:Button ID="Button6" runat="server" Text="减一" OnClick="Button6_Click" />&nbsp;
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="追加" />
            &nbsp;
            <asp:Button ID="Button7" runat="server" Text="删除" OnClick="Button7_Click" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="返回" OnClick="Button4_Click" />
        </div>
    </form>
</body>
</html>
