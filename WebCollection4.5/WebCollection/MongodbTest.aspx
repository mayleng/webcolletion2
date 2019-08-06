<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MongodbTest.aspx.cs" Inherits="WebCollection.MongodbTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             MongoDB 数据库测试：MongoDB.Driver 2.5（agent暂不支持该版本）<br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="创建&amp;添加" Onclick="btnCreate_Add"/>
        &nbsp;
       
        <asp:Button ID="Button3" runat="server" Text="修改" Onclick="btnEdit"/>
        &nbsp;
        <asp:Button ID="Button4" runat="server" Text="查询" Onclick="btnSearch"/> &nbsp;
        <asp:Button ID="Button2" runat="server" Text="删除" Onclick="btnDelete"/>
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="返回" Onclick="btnBack"/>
        </div>
    </form>
</body>
</html>
