using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Memcached.ClientLibrary;
using System.Configuration;
using System.Threading;

namespace WebCollection
{
    public partial class MemcacheTest : System.Web.UI.Page
    {
        //创建静态字段作为全局变量
        public static MemcachedClient MClient;

        //将连接数据库的操作封装成一个方法
        protected void GetDb(out MemcachedClient MClient)
        {
            //参数设置
            string SockIOPoolName = "Test_SockIOPoolName";
            string[] MemcacheServiceList = { "192.168.0.180:11211" };

            //设置连接池
            SockIOPool SPool = SockIOPool.GetInstance(SockIOPoolName);
            SPool.SetServers(MemcacheServiceList);
            SPool.Initialize();


            //实例化Client
            MClient = new MemcachedClient();
            MClient.PoolName = SockIOPoolName;

            Thread.Sleep(12);
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //返回
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Database.aspx");
        }


        //增加
        protected void Button1_Click(object sender, EventArgs e)
        {
            GetDb(out MemcachedClient MClient);
            bool incre = MClient.Add("key1", "helloworld");
            MClient.Set("key2", 12);
            MClient.Set("key3", 3.1415);
            MClient.Add("key4","设置过期时间", DateTime.Now.AddMinutes(1));
            MClient.Set("key5", "good", 4);
            MClient.Set("key6","20");

            string s = MClient.Get("key1").ToString();
          
            if (s == "helloworld"&& incre == true)
            {
                Response.Write("<script>alert('添加成功!')</script>");
            }
            else
            {
                Response.Write("<script>alert('添加失败!')</script>");
            }
            
        }

        //查询
        protected void Button2_Click(object sender, EventArgs e)
        {
            GetDb(out MemcachedClient MClient);
            if (MClient.KeyExists("key1"))
            {
                Response.Write(MClient.Get("key1"));
            }
            else
            {
                Response.Write("<script>alert('查询失败!')</script>");
            }
        }
        //修改
        protected void Button3_Click(object sender, EventArgs e)
        {
            GetDb(out MemcachedClient MClient);
            bool  s= MClient.Replace("key1", "replace你好");

            if (s == true)
            {
                Response.Write("<script>alert('修改成功!')</script>");
                Response.Write(MClient.Get("key1"));
            }
            else
            {
                Response.Write("<script>alert('修改失败!')</script>");
            }
        }

        //删除
        protected void Button4_Click(object sender, EventArgs e)
        {
            GetDb(out MemcachedClient MClient);
            if (MClient.KeyExists("key1"))
            {
               bool t = MClient.Delete("key1");

               //清除所有的缓存
                MClient.FlushAll();
                if (t == true)
                {
                    Response.Write("<script>alert('删除成功!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('删除失败!')</script>");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("/MemcacheTests/EnyimTest.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("/MemcacheTests/BeITMemcacheTest.aspx");
        }
    }
}