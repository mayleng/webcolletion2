<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedisTests.aspx.cs" Inherits="WebCollection.RedisTests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Redis 数据库测试！
         
             
            <br />
            <br />
         
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="StackExchange.Redis" Height="21px" OnClick="Button1_Click" Width="171px" />&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="NServiceKit.Redis" OnClick="Button2_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="ServiceStack.Redis" OnClick="Button3_Click" />&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="返回" />
    </form>
</body>
</html>
