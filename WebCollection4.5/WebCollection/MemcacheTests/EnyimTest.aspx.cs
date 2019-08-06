using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection.MemcacheTests
{
    public partial class EnyimTest : System.Web.UI.Page
    {
        public MemcachedClient client;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public EnyimTest()
        {
            string myConn = ConfigurationManager.AppSettings["memcache"].ToString();
            MemcachedClientConfiguration config = new MemcachedClientConfiguration();
            config.AddServer(myConn, 11211);
            config.Protocol = MemcachedProtocol.Binary;
            client = new MemcachedClient(config);
        }
        //返回
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/MemcacheTest.aspx");
        }
        //增加
        protected void Button2_Click(object sender, EventArgs e)
        {
           client.Store(StoreMode.Add, "x", 5);
            client.Store(StoreMode.Add, "y", "test");
            bool result = client.Store(StoreMode.Add, "zz", "abc");
            if (result)
            {
                Response.Write("<script>alert('添加成功!')</script>");
            }
            else
                Response.Write("<script>alert('添加成功!')</script>");
           
        }
        //查询
        protected void Button3_Click(object sender, EventArgs e)
        {
            string responseText = " ";
            try
            {
                object obj = client.Get("y");
                if (obj != null)
                {
                    responseText = "查找成功,值为：" + obj.ToString();
                }
                else
                    responseText = "查找失败，值为空";
            }
            catch (Exception ex)
            {
                responseText = "查找失败！" + ex.Message;
            }
            Response.Write("<script>alert('" + responseText + "')</script>");
        }
        //修改
        protected void Button4_Click(object sender, EventArgs e)
        {
            bool result = client.Store(StoreMode.Set, "zz", "def");
            client.Store(StoreMode.Replace, "zz", "wer");
            if (result)
            {
                Response.Write("<script>alert('修改成功!')</script>");
            }
            else
                Response.Write("<script>alert('修改成功!')</script>");
        }
        //加一
        protected void Button5_Click(object sender, EventArgs e)
        {
            ulong result = client.Increment("x", 10, 1);
            Response.Write("<script>alert('" + result + "')</script>");
        }
        //减一
        protected void Button6_Click(object sender, EventArgs e)
        {
            ulong result = client.Decrement("x", 10, 1);
            Response.Write("<script>alert('" + result + "')</script>");
        }
        //前追加
        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = { 50 };
                ArraySegment<byte> pend = new ArraySegment<byte>(b);
                bool result = client.Prepend("y", pend);
                if (result)
                {
                    Response.Write("<script>alert('向前追加数据成功!')</script>");
                }
                else
                    Response.Write("<script>alert('向前追加数据失败!')</script>");
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }


        }
        //后追加
        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] b = { 49 };
                ArraySegment<byte> pend = new ArraySegment<byte>(b);
                bool result = client.Append("y", pend);
                if (result)
                {
                    Response.Write("<script>alert('向后追加数据成功!')</script>");
                }
                else
                    Response.Write("<script>alert('向后追加数据失败!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }

        }
        //删除
        protected void Button9_Click(object sender, EventArgs e)
        {
           client.Remove("x");
            client.Remove("y");
            bool result = client.Remove("zz");
            if (result)
            {
                Response.Write("<script>alert('删除成功!')</script>");
            }
            else
                Response.Write("<script>alert('删除数据失败!')</script>");

        }
    }
}