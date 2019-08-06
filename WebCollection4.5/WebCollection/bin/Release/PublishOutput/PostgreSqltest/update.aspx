<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="WebCollection.PostgreSqltest.updata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            PostgreSql修改数据测试！<br />
        <br />
        &nbsp;表名：&nbsp;<asp:TextBox ID="tableName" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;<br />
            <br />
&nbsp; 属性：<asp:TextBox ID="pro" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;属性值：<asp:TextBox ID="provalue" runat="server"></asp:TextBox>
            <br />
            <br />
            修改状态：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox5" runat="server" Width="512px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="确定" OnClick="Button2_Click" />&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="返回" />
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
