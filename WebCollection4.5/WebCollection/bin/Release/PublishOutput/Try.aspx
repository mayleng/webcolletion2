<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Try.aspx.cs" Inherits="WebCollection.Try" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            异常在类Try下
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="异常一" OnClick="Button2_Click" />&nbsp;
            <asp:Button ID="Button4" runat="server" Text="异常二" OnClick="Button4_Click" />&nbsp;
            <asp:Button ID="Button3" runat="server" Text="异常三" OnClick="Button3_Click" />&nbsp;
            <asp:Button ID="Button5" runat="server" Text="异常四" OnClick="Button5_Click" />&nbsp;
            <asp:Button ID="Button6" runat="server" Text="异常五" OnClick="Button6_Click" />&nbsp;
            <asp:Button ID="Button7" runat="server" Text="异常六" OnClick="Button7_Click" />&nbsp;
            <asp:Button ID="Button8" runat="server" Text="异常七" OnClick="Button8_Click" />&nbsp;
            <asp:Button ID="Button9" runat="server" Text="异常八" OnClick="Button9_Click" />&nbsp;
            <asp:Button ID="Button10" runat="server" Text="异常九" OnClick="Button10_Click" />&nbsp;
            <asp:Button ID="Button11" runat="server" Text="异常十" OnClick="Button11_Click" />&nbsp;
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="返回" />
        <br />
        <br />
        显示设置的服务器缓存：<asp:TextBox ID="CacheTextBox" runat="server"></asp:TextBox>
    </form>

    <img src="/images/3764872_215617048242_2.jpg"/>

</body>
</html>
