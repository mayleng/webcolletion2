<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnyimTest.aspx.cs" Inherits="WebCollection.MemcacheTests.EnyimTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             使用的memcache的驱动为Enyim.Cahing.Memcached.
            <br />
             EnyimMemcached 2.7.0&nbsp; Nuget里下载<br />
             加一 减一用法有点问题。<br />
            <br />
             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="增加" />
&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button3" runat="server" Height="24px" OnClick="Button3_Click" Text="查询" />
&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="修改" />
&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="加一" />
&nbsp;&nbsp;
            <br />
            <br />
             <br />
            <br />
             <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="减一" />
&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="前追加" />
&nbsp;&nbsp;
             <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="后追加" />
&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="删除" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="返回" />
        </div>
    </form>
</body>
</html>
