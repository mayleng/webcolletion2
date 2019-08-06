using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection
{
    public partial class AccessData : System.Web.UI.Page
    {
        public OleDbConnection  con;
        public OleDbCommand cmd;
       

        protected void Page_Load(object sender, EventArgs e)
        {       
        }

        //在构造方法中初始化数据库连接
        public AccessData()
        {
            OleDbConnectionStringBuilder oleString = new OleDbConnectionStringBuilder();
            oleString.Provider = "Microsoft.ACE.OLEDB.12.0";
            oleString.DataSource = Server.MapPath("App_Data/users.accdb");

           con = new OleDbConnection();

            //创建OleDb连接对象
            con.ConnectionString = oleString.ToString();
            cmd = new OleDbCommand();
           
        }

        //插入数据
        protected void Button2_Click(object sender, EventArgs e)
        {
            string UserId = TextBox1.Text.Trim();
            string Userpwd = TextBox2.Text.Trim();
         
            try
            {
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "Insert into user_table (user_id,user_pwd) values(@UserId,@UserPwd)";
                //并且用sql参数形式插入数据
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@UserPwd", Userpwd);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('添加数据成功！！ ')</script>");
            }
            catch (Exception ex)
            {
                string mss = ex.Message;                          
                TextBox6.Text = mss;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
        }

        //查询数据
        protected void Button3_Click(object sender, EventArgs e)
        {
            string UserId = TextBox3.Text.Trim();
            try
            {
                con.Open();
                cmd.Connection = con;
              
                cmd.CommandText = "select  * from user_table WHERE user_id= @UserId";
                cmd.Parameters.AddWithValue("@UserId", UserId);
             
                //返回查询结果的第一行的第一列，这里返回id
                int n =(int)cmd.ExecuteScalar();
               
             if (n>=1)
                {
                    Response.Write("<script>alert('查询数据成功！！ ')</script>");
                }
                else
                {
                  Response.Write("<script>alert('表中没有此用户！！ ')</script>");
                }
                            
            }
            catch (Exception ex)
            {
                string mss = ex.Message;
                TextBox7.Text = mss;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

        //删除数据
        protected void Button4_Click(object sender, EventArgs e)
        {
            string user_id = TextBox5.Text.Trim();

            try
            {
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "delete from user_table WHERE user_id= @UserId";
                cmd.Parameters.AddWithValue("@UserId", user_id);            

                if (cmd.ExecuteNonQuery()>=1)
                {
                    Response.Write("<script>alert('删除数据成功！！ ')</script>");
                }
                else
                {
                    Response.Write("<script>alert('用户不存在！！ ')</script>");
                }

            }
            catch (Exception ex)
            {
                string mss = ex.Message;
                TextBox8.Text = mss;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }

        //返回
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Database.aspx");
        }

    }
}