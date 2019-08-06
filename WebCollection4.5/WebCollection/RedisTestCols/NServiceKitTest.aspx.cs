using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NServiceKit.Redis;
using NServiceKit.Redis.Support;
using System.Configuration;

namespace WebCollection.RedisTestCols
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //RedisClient继承RedisNativeClient类
        public static RedisClient dbclient;
        //将连接数据库封装成一个方法
        protected void GetdbClient(out RedisClient dbclient)
        {
            //连接数据库
            string conn = System.Configuration.ConfigurationManager.AppSettings["redis2"].ToString();
            dbclient = new RedisClient(conn);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //添加
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
           GetdbClient(out RedisClient dbclient);
           bool n =dbclient.Add<string>("name","yueyue");
                dbclient.Add<int>("age",2);
                //add 添加不可覆盖键值，set会覆盖同键的值
                dbclient.Add<int>("number",158);
                dbclient.Set<string>("test","hh");

                if (n==true)
                {
                    Response.Write("<script>alert('添加成功!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败!')</script>");
                }
             }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //查询
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);
                string name = dbclient.Get<string>("name");
                dbclient.Get<int>("age");
               
                if (name == "yueyue")
                {
                    Response.Write("<script>alert('" + name +  "')</script>");
                }
                else
                {
                    Response.Write("<script>alert('查询失败!')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //追加
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);
                dbclient.AppendToValue("test","good");
                Response.Write("<script>alert('追加数据成功!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //加一
        protected void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);
                dbclient.Increment("number", 2);
                dbclient.IncrementValue("number");

                int num = dbclient.Get<int>("number");
                Response.Write("每次结果加3" + "<script>alert('" + num + "')</script>");


            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //减一
        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);
                //减二
                //dbclient.Decrement("number",2);
                dbclient.DecrBy("number", 2);//调用父类方法
                //减一
                //dbclient.DecrementValue("number");
                dbclient.Decr("number");
                int num = dbclient.Get<int>("number");
                Response.Write("每次结果减3"+"<script>alert('" + num + "')</script>");

            }
            catch (Exception ex)
            {
                Response.Write("操作失败"+ex.Message);
            }
        }

        //删除
        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);
                //调用父类的方法
                dbclient.Del("test");
                dbclient.Del("name");
                dbclient.Del("age");
                dbclient.Del("number");
               

                Response.Write("<script>alert('删除成功!')</script>");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        //返回
        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RedisTests.aspx");
        }
    }
}