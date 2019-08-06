<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinqTest.aspx.cs" Inherits="WebCollection.LinqTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>c#提供的ling查询极大的遍历了集合的查询过程，且使用简单方便，非常的有用.</p>
            <br />
            <asp:Button ID="Button2" runat="server" Text="基本查询" OnClick="Button2_Click" />&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="延迟查询" OnClick="Button3_Click" />&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="类型帅选" />&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="复合from子句" OnClick="Button5_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="多级排序" />&nbsp;&nbsp;
            <br />
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
