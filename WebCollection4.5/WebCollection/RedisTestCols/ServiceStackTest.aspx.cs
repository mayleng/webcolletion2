using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceStack.Redis;


namespace WebCollection.RedisTestCols
{
    public partial class ServiceStackTest : System.Web.UI.Page
    {
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

        //增加
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);

                string username = "moon";
                string personality = "brave";
                string external = "cute";
              

                int w1 = 75;
                int w2 = 88;
                dbclient.Set<int>("w1",w1);
                dbclient.Set<int>("w2", w2);


                //添加string类型
                dbclient.Set<string>("username", username);
                dbclient.Set<string>("personality", personality);
                dbclient.Set<string>("external", external);
               

                // 添加Hash类型
                string title = "pig peiqi";
                string price = "12.5";
                dbclient.SetEntryInHash("books","title",title);
                dbclient.SetEntryInHash("books", "price", price);

                //添加list队列类型
                string num1 = "12";
                string num2 = "34";
                dbclient.EnqueueItemOnList("queue", num1);
                dbclient.EnqueueItemOnList("queue", num2);

                //添加list栈类型
                dbclient.PushItemToList("stack", num1);
                dbclient.PushItemToList("stack", num2);

                //添加set类型
                dbclient.AddItemToSet("a", "aaaa1");
                dbclient.AddItemToSet("a", "aaaa2");
                dbclient.AddItemToSet("a", "aaaa3");

                //添加Sorted Set类型（在set的基础上增加了一个顺序的属性）
                dbclient.AddItemToSortedSet("s", "a");
                dbclient.AddItemToSortedSet("s", "b");
                dbclient.AddItemToSortedSet("s", "c");
                dbclient.AddItemToSortedSet("s", "abc");
                dbclient.AddItemToSortedSet("s", "defg");


                var exist = dbclient.Exists("username");
                if (exist == 1)
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
                Response.Write("添加失败！"+ex.Message);
            }
        }

       //查询
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);

                string username = dbclient.Get<string>("username");
                string personality = dbclient.Get<string>("personality");

                //返回Hash类型结果
                List<string> keylist = dbclient.GetHashKeys("books");
                List<string> valuelist = dbclient.GetHashValues("books");
                Response.Write("Hash结果：");
                for(int i = 0; i < keylist.Count; i++)
                {
                    Response.Write(keylist[i]+valuelist[i]+", ");
                }

                //返回list队列结果
                int Qcount = dbclient.GetListCount("queue");
                Response.Write("</br>" + "List队列输出结果：");
                for (int i = 0; i < Qcount; i++)
                {
                    Response.Write(dbclient.DequeueItemFromList("queue") + ",");
                }

                // 返回List栈
                int Scount = dbclient.GetListCount("stack");
                Response.Write("</br>"+"List栈输出结果：");
                for (int i = 0; i < Scount; i++)
                {
                   Response.Write(dbclient.PopItemFromList("stack") + ",");
                }

                //返回set类型
                Response.Write("</br>" + "set输出结果：");
                System.Collections.Generic.HashSet<string> hashset = dbclient.GetAllItemsFromSet("a");
                foreach (string str in hashset)
                {
                   Response.Write(str+",  ");
                }

                //返回Sorted set类型
                Response.Write("</br>" + "Sorted set输出结果：");
                System.Collections.Generic.List<string> list = dbclient.GetAllItemsFromSortedSet("s");
                foreach (string str in list)
                {
                    Response.Write(str+", ");
                }


                if (username=="moon")
                {
                    Response.Write("<script>alert('" + username + personality+ "')</script>");
                }
                else
                {
                    Response.Write("<script>alert('查询失败!')</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("查询失败！" + ex.Message);
            }
        }

        //追加
        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);
                byte[] q = {0,2,3,4 };
                dbclient.Append("w1", q);
                dbclient.AppendToValue("w1", "test");
                dbclient.PrependItemToList("queue","add");
                
                Response.Write("<script>alert('追加数据成功!')</script>");

            }
            catch (Exception ex)
            {
                Response.Write("追加数据失败！" + ex.Message);
            }

        }

        //加一
        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);
                dbclient.Incr("w2");
                int w2value = dbclient.Get<int>("w2");
                Response.Write("<script>alert('" + w2value + "')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("添加失败！" + ex.Message);
            }
        }

        //减一
        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);
                dbclient.Decr("w2");
                int w2value = dbclient.Get<int>("w2");

                Response.Write("<script>alert('" + w2value + "')</script>");

            }
            catch (Exception ex)
            {
                Response.Write("添加失败！" + ex.Message);
            }
        }

        //删除
        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                GetdbClient(out RedisClient dbclient);
                var a = dbclient.Del("personality");
                dbclient.Del("username");
                dbclient.Del("external");
                dbclient.Del("baby");
                dbclient.Del("books");
                dbclient.Del("queue");
                dbclient.Del("stack");
                dbclient.Del("a");
                dbclient.Del("s");
                dbclient.Del("w1");
                dbclient.Del("w2");

                if (a ==1)
                {
                    Response.Write("<script>alert('删除成功!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('删除失败!')</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("删除失败！" + ex.Message);
            }
        }

        //返回
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RedisTests.aspx");
        }

        
    }
}