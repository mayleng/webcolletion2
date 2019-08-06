<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StackExchange.aspx.cs" Inherits="WebCollection.RedisTest.StackExchange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div> 
            StackExchange.Redis安装版本1.2.7
            <br />
            <br />
            <br />
            <br />
        </div>

         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" />&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="查询" />&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="加一" />&nbsp;
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="减一" />&nbsp;
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="追加" />&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="删除" />&nbsp;
        <p>
            &nbsp;</p>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="返回" />


        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>


    </form>
</body>
</html>
