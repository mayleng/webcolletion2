<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BeITMemcacheTest.aspx.cs" Inherits="WebCollection.MemcacheTests.BeITMemcacheTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             使用的是BeITMemcached。
         
            <br />
             BeIT.MemCached.dll 1.0.0.0(在网上下载<span style="color: rgb(0, 0, 0); font-family: Verdana, Geneva, Arial, Helvetica, sans-serif; font-size: 13px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(238, 238, 221); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">&nbsp;BeITMemcached.dll文件，然后引入到项目中。</span>)<br />
             <br />
            <br />
            <br />
             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="增加" />
&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="查找" />
&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="修改" />
&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="加一" />
&nbsp;&nbsp;
             <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="减一" />
&nbsp;<br />
            <br />
            &nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="前追加" />
&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="后追加" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="删除" />
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
