<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HttpWebRequests.aspx.cs" Inherits="WebCollection.HttpWebRequests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="SimpleGet" OnClick="Button1_Click" />
         &nbsp;
        <asp:Button ID="Button2" runat="server" Text="local" OnClick="Button2_Click" />
         &nbsp;
        <asp:Button ID="Button3" runat="server" Text="Post" OnClick="Button3_Click" />
        &nbsp;<asp:Button ID="Button5" runat="server" Text="local error" OnClick="Button5_Click" />
        <br />
        <br />
        下面的业务为了测试跨容器调用链：<br />
        此业务为A业务，点击localB 调用B业务； 点击localC调用c 业务：B业务也会调用C业务<br/><br/>
        <asp:Button ID="Button6" runat="server" Text="LocalB" OnClick="Button6_Click" />&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" Text="localC" OnClick="Button7_Click" />
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button8" runat="server" Text="Java业务" OnClick="Button8_Click" />&nbsp;&nbsp;
&nbsp;&nbsp;<p>
            <asp:Button ID="Button4" runat="server" Text="返回" OnClick="Button4_Click" />
        </p>
    </form>
</body>
</html>
