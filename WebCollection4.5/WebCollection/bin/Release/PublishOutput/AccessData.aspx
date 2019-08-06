<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccessData.aspx.cs" Inherits="WebCollection.AccessData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Access数据库测试页面！<br />
            （使用System.Data.OleDb是微软自带的，需要安装ACE引擎才能在程序中调用数据库。）<br />
            <br />
            <br />
            插入用户：<br />
            用户id：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; 用户密码：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            结果：&nbsp;&nbsp;
            <br />
<asp:TextBox ID="TextBox6" runat="server" Height="64px" Width="319px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Height="24px" Text="插入" OnClick="Button2_Click" />
            &nbsp; &nbsp;
            <br />
            <br />
            <br />
            查询用户：<br />
            用户id：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;
            <br />
            结果：&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
<asp:TextBox ID="TextBox7" runat="server" Height="64px" Width="319px"></asp:TextBox>
            &nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Height="26px" Text="查询" Width="52px" OnClick="Button3_Click" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            删除用户：<br />
            用户id：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;
            <br />
            结果：&nbsp;
            <br />
<asp:TextBox ID="TextBox8" runat="server" Height="64px" Width="319px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;<asp:Button ID="Button4" runat="server" Height="27px" Text="删除" OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="返回" />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
