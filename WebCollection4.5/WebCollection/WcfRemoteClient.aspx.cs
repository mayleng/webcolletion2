using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection
{
    //自定义一个接口
    public interface IMytest
    {
        void  MyInterfaceMethod1();
        string MyInterfaceMethod2();
    }

    public partial class WcfRemoteClient : System.Web.UI.Page,IMytest
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public  void MyInterfaceMethod1()
        {
            Thread.Sleep(20);
            int a = 1;
            int b = 11;
            Response.Write("MyInterfaceMethod1方法执行结果：");
            Response.Write(a+b);
           
        }


        public string  MyInterfaceMethod2()
        {
            Thread.Sleep(20);
            string a = "moon";
            string b = "great";
            Response.Write("MyInterfaceMethod2方法执行结果：");
            Response.Write(a + b);
            return "good";
        }

        //返回
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        //调用方法一
        protected void Button1_Click(object sender, EventArgs e)
        {
            MyInterfaceMethod1();
        }

        //调用方法二
        protected void Button2_Click(object sender, EventArgs e)
        {
            MyInterfaceMethod2();
        }

        //调用自定义类
        protected void Button4_Click(object sender, EventArgs e)
        {
            InterBase b = new InterBase();
            int a = b.MyInterfaceMethod3();
            string c = b.MyInterfaceMethod4();
            Response.Write("a=" + a.ToString() +"     ;"+ "c=" + c);
        }
    }
}