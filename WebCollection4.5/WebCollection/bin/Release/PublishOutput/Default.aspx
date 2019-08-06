<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCollection.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 543px; width: 862px">
    <form id="form1" runat="server">
        <div>
        </div>
           <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="异常try" />
        &nbsp; &nbsp;  <asp:Button ID="Button7" runat="server" Text="泛型函数测试" OnClick="Button7_Click" />
         &nbsp; &nbsp;  <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="system trace log" />  &nbsp; &nbsp;<asp:Button ID="Button9" runat="server" Text="抽象方法使用" OnClick="Button9_Click" />
        &nbsp;<br />
        <br />
&nbsp;<asp:Button ID="Button4" runat="server" Text="远程调用httpwebrequest" OnClick="Button4_Click" />
        &nbsp; &nbsp;  <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="不同参数测试" />
          &nbsp; &nbsp; <asp:Button ID="Button8" runat="server" Text="自定义程序集引用" OnClick="Button8_Click" />
        <br />
        <br />
        <asp:Button ID="Button10" runat="server" Text="继承接口类测试" OnClick="Button10_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Linq相关" />&nbsp;&nbsp;
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="递归" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="数据库测试" />&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <p>
            <asp:Button ID="Button5" runat="server" Text="TestStore" OnClick="Button5_Click" />&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
