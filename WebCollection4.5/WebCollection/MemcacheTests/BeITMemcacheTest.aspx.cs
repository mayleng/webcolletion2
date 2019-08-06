using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BeIT.MemCached;


namespace WebCollection.MemcacheTests
{
    public partial class BeITMemcacheTest : System.Web.UI.Page
    {
        public MemcachedClient client;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //在构造函数中建造连接客户端
        public BeITMemcacheTest()
        {
            string myConn = ConfigurationManager.AppSettings["memcache"].ToString();
            string[] servers = new string[1];
            servers[0] = myConn + ":11211";

            if (!MemcachedClient.Exists("MyCache"))
                MemcachedClient.Setup("MyCache", servers);
            client = MemcachedClient.GetInstance("MyCache");
        }


        //增加
        protected void Button2_Click(object sender, EventArgs e)
        {
            client.Add("a", 5);
            client.Add("b", "test");
            bool result = client.Add("cc", "1234");
            if (result)
            {
                Response.Write("<script>alert('添加成功!')</script>");
            }
            else
                Response.Write("<script>alert('添加成功!')</script>");
        }
        //查找
        protected void Button3_Click(object sender, EventArgs e)
        {
            string responseText = " ";
            try
            {
                Object obj = client.Get("cc");
                if (obj != null)
                {
                    responseText = "查找成功,值为：" + obj.ToString();
                }
                else
                    responseText="查找失败，值为空";
            }
            catch (Exception ex)
            {
                responseText="查找失败！" + ex.Message;
            }
            Response.Write("<script>alert('" + responseText + "')</script>");
        }

        //修改
        protected void Button4_Click(object sender, EventArgs e)
        {
            bool result = client.Set("b", "newtest");
            if (result)
            {
                Response.Write("<script>alert('修改成功!')</script>");
            }
            else
                Response.Write("<script>alert('修改成功!')</script>");
        }
        //返回
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/MemcacheTest.aspx");
        }
        //加一
        protected void Button6_Click(object sender, EventArgs e)
        {
            ulong result = (ulong)client.Increment("a", 1);
            Response.Write("<script>alert('" + result + "')</script>");
        }
        //减一
        protected void Button7_Click(object sender, EventArgs e)
        {
            ulong result = (ulong)client.Decrement("a", 1);
            Response.Write("<script>alert('" + result + "')</script>");
        }
        //向前追加
        protected void Button8_Click(object sender, EventArgs e)
        {
           bool result= client.Prepend("b", "q");
            if (result)
            {
                Response.Write("<script>alert('向前追加数据成功!')</script>");
            }
            else
                Response.Write("<script>alert('向前追加数据失败!')</script>");
        
    }
       // 向后追加数据
        protected void Button9_Click(object sender, EventArgs e)
        {
            bool result = client.Append("b", "h");
            if (result)
            {
                Response.Write("<script>alert('向后追加数据成功!')</script>");
            }
            else
                Response.Write("<script>alert('向后追加数据失败!')</script>");

        }
        //删除
        protected void Button5_Click(object sender, EventArgs e)
        {
            bool result = client.Delete("a");
            client.Delete("b");
            client.Delete("c");
            if (result)
            {
                Response.Write("<script>alert('删除成功!')</script>");
            }
            else
                Response.Write("<script>alert('删除数据失败!')</script>");

        }
    }
}