using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StackExchange.Redis;


namespace WebCollection.RedisTest
{
    public partial class StackExchange : System.Web.UI.Page
    {
        //创建静态字段作为全局变量
        public static IDatabase db;

        //将连接数据库的操作封装成一个方法
        protected void GetDb(out IDatabase db)
        {
            //连接数据库
            string conn = System.Configuration.ConfigurationManager.AppSettings["redis"].ToString();
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(conn);

            //访问数据库  给db赋值
            db = redis.GetDatabase();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //返回
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RedisTests.aspx");

        }

        //增加
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                GetDb(out db);

                //string类型
                string value = "123";
                db.StringSet("mykey", value);
                db.StringSetAsync("yy","45");
                db.StringSet("qw", "qwe");
                db.StringGetSet("qw", "qw");
                db.StringSetAsync("ff","ff");
                db.StringGetSetAsync("ff", "ff1");
                //设置带过期时间的
                db.StringSet("key2", "keyTest2", new TimeSpan(0, 0, 5));

                //hash类型
                db.HashSet("a","a1",1);
                db.HashSetAsync("a1", "a2", 1);
                db.HashSet("b", new HashEntry[] { new HashEntry("b", "2"), new HashEntry("c", "3") });

                //list类型
                long index = db.ListLeftPush("c", "test");
                string value2 = db.ListGetByIndex("c", index - 1);

                long index2 = db.ListInsertAfter("c", "test", "testright");
                string value3 = db.ListGetByIndex("c", index2 - 1);

                long index3 = db.ListInsertBefore("c", "test", "testleft");
                string value4 = db.ListGetByIndex("c", index3 - 1);
                Response.Write("list 类型c=" + value2+"cright="+value3+"cleft="+value4);
                Response.Write("</br>");

                db.ListSetByIndex("c",1,"set c");

              RedisValue[] values = db.ListRange("c");
                values.ToList().ForEach((v) =>
                {
                    Response.Write(v + "\n\n");
                });

                db.ListLeftPushAsync("c1", "mm");
                db.ListRightPushAsync("c1", "vb");
                db.ListInsertAfterAsync("c1","mm","dr");
                db.ListInsertBeforeAsync("c1", "mm", "ds");
                db.ListGetByIndexAsync("c1",0);
                db.ListSetByIndexAsync("c1",1,"set c1");
              

                string s = db.StringGet("mykey");
                if (s == "123")
                {
                    Response.Write("<script>alert('添加成功!')</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('添加失败!')</script>");
            }

        }

        //查询
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                GetDb(out db);
                string value = db.StringGet("mykey");
                db.StringGetAsync("yy");
                db.HashGet("a","a1");
                db.HashGetAsync("a1","a2");
                db.HashGetAll("a");
                db.HashGetAllAsync("a1");
               bool exist= db.HashExists("a", "a1");
                Response.Write("hash exsit="+exist);

                HashEntry[] values = db.HashGetAll("b");

                Response.Write("<script>alert(" + value + ")</script>");
            }
            catch
            {
                Response.Write("<script>alert('查询失败!')</script>");
            }

        }

        //加一
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                GetDb(out db);
                string value = db.StringIncrement("mykey").ToString();
                db.StringIncrementAsync("yy",4);
                Response.Write("<script>alert(" + value + ")</script>");
            }
            catch
            {
                Response.Write("<script>alert('操作失败！')</script>");
            }

        }

        //减一
        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                GetDb(out db);
                string value = db.StringDecrement("mykey").ToString();
                db.StringDecrementAsync("yy",5);
                Response.Write("<script>alert(" + value + ")</script>");

            }
            catch
            {
                Response.Write("<script>alert('操作失败')</script>");
            }
        }

        //追加
        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                GetDb(out db);
                //追加返回的不是追加后的值 具体后期看api
                string value = db.StringAppend("mykey", "7").ToString();
                db.StringAppendAsync("qw","qw");

                Response.Write("<script>alert(" + value + ")</script>");
            }
            catch
            {
                Response.Write("<script>alert('追加失败!')</script>");
            }
        }

        //删除
        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                GetDb(out db);
                bool b = db.KeyDelete("mykey");
                db.KeyDeleteAsync("ff");

                db.HashDelete("a", "a1");
                db.HashDeleteAsync("a1","a2");

                long index4 = db.ListRemove("c", "test");
                RedisValue[] values = db.ListRange("c");
                values.ToList().ForEach((v) =>
                {
                    Response.Write(v+"\n\n");
                });

                db.ListLeftPop("c");
                db.ListRightPop("c");
               

                db.ListRemoveAsync("c1","mm");
                db.ListLeftPopAsync("c1");
                db.ListRightPopAsync("c1");


                if (b)
                {
                    Response.Write("<script>alert('删除成功!')</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('删除失败!')</script>");
            }

        }


    }
}