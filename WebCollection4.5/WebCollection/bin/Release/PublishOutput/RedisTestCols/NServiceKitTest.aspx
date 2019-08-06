<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NServiceKitTest.aspx.cs" Inherits="WebCollection.RedisTestCols.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            NServiceKit.Redis安装版本1.0.20<br />
            ServiceStack.Redis从v4开始收费了，NServiceKit.Redis是这个程序的免费开源版本.
            其源码与ServiceStack.Redis v3基本相同.
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />&nbsp;
        <asp:Button ID="Button2" runat="server" Text="查询" OnClick="Button2_Click" />&nbsp;
        <asp:Button ID="Button3" runat="server" Text="追加" OnClick="Button3_Click" />&nbsp;
        <asp:Button ID="Button4" runat="server" Text="加一" OnClick="Button4_Click" />&nbsp;
        <asp:Button ID="Button5" runat="server" Text="减一" OnClick="Button5_Click" />&nbsp;
        <asp:Button ID="Button6" runat="server" Text="删除" OnClick="Button6_Click" />&nbsp;
        <br />
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Text="返回" OnClick="Button7_Click" />
    </form>
</body>
</html>
