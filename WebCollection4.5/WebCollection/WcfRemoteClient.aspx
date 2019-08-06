<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WcfRemoteClient.aspx.cs" Inherits="WebCollection.WcfRemoteClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            该页面与wcf无任何关系，原页面更改的测试接口相关的热点快照业务。<br/>
            该页面定义了一个接口，该类继承该接口，并实现。
            <br/>
            接口： WebCollection.IMytest
            <br/>
            继承接口的类：WebCollection.WcfRemoteClient
            (该类继承page)<br/>
            接口中方法：MyInterfaceMethod1();MyInterfaceMethod2();
            <br />
            <br />
            自定义不继承page类：WebCollection.InterBase<br />
            自定义类继承的接口：WebCollection.IMytest2<br/>
            接口中方法：MyInterfaceMethod3();MyInterfaceMethod4();
            <br />
            <br />
            <br />
            <br/>
            <asp:Button ID="Button1" runat="server" Text="调用接口方法一" OnClick="Button1_Click" />&nbsp;
            <asp:Button ID="Button2" runat="server" Text="调用接口方法二" OnClick="Button2_Click" />&nbsp;
            <asp:Button ID="Button4" runat="server" Text="调用自定义类" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="返回" />
            <br/>

        </div>
    </form>
</body>
</html>
