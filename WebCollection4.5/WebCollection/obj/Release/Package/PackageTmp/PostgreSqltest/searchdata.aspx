﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchdata.aspx.cs" Inherits="WebCollection.PostgreSqltest.searchdata" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
        
        PostgreSql查询数据测试！<br />
        <br />
        表名：<asp:TextBox ID="tb0" runat="server"></asp:TextBox>
    
        <br />
        <br />
        条件属性：<asp:TextBox ID="tb1" runat="server"></asp:TextBox>
&nbsp;&nbsp; 条件值：<asp:TextBox ID="tb2" runat="server"></asp:TextBox>

        <br />
        <br />
        查询状态： 
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="228px"></asp:TextBox>

        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="确定" Onclick="btnsearchdata"/>

        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回" Onclick="btnback"/>
        <br />

        <br />

    <asp:DataGrid runat="server" CssClass="DataList" AutoGenerateColumns="True" Id="dtg" OnSelectedIndexChanged="dtg_SelectedIndexChanged"></asp:DataGrid>
    
    </div>
    </form>
</body>
</html>
