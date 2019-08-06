<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Database.aspx.cs" Inherits="WebCollection.Database" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    数据库测试网站<br/>
    <br/>
    <form id="form1" runat="server">
    
            <asp:Button ID="Button2" runat="server" Text="Oracle" />
         &nbsp;
      
        <asp:Button ID="Button1" runat="server" Text="Mysql" />
      &nbsp;
            <asp:Button ID="Button3" runat="server" Text="Postgresql" OnClick="Button3_Click" />
     &nbsp;
        <asp:Button ID="Button4" runat="server" Text="Sqlserver" OnClick="Button4_Click" />
       &nbsp;
            <asp:Button ID="Button5" runat="server"  Text="Memcache" OnClick="Button5_Click" />
       &nbsp;
        <asp:Button ID="Button6" runat="server" Text="Redis" OnClick="Button6_Click" />
      &nbsp;
            <asp:Button ID="Button7" runat="server" Text="Mongdb" OnClick="Button7_Click" />
&nbsp;&nbsp;<br />
            <br />
            <br />
          <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Access" />
            &nbsp;&nbsp;<br />
            <br />
            &nbsp;
       &nbsp;
            <p>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="返回" />
            </p>
    </form>
</body>
</html>
