<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemcacheTest.aspx.cs" Inherits="WebCollection.MemcacheTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
           使用Memcached.ClientLibrary.dll客户端调用方法
            (Memcached.ClientLibrary版本1.0.0)<br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="增加" OnClick="Button1_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="查询" OnClick="Button2_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="修改" OnClick="Button3_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="删除" OnClick="Button4_Click" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Enyim.Cahing.Memcached" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="BeITMemcached" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="返回" />
    </form>
</body>
</html>
