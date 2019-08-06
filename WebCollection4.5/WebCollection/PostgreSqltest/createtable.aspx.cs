using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Configuration;
using System.Text;
using Npgsql;

namespace WebCollection.PostgreSqltest
{
    public partial class createtable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate(object sender, EventArgs e)
        {
            String tablename = t0.Text.Trim();
            String key = t1.Text.Trim();
            String prop1 = t2.Text.Trim();

            TextBox1.Text = " ";
            NpgsqlConnection conn = new NpgsqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PostgreSqlConStr"].ConnectionString.ToString());

            if (conn == null)
            {
                return;
            }
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                TextBox1.Text = "conn.Open 失败 " + ex.Message;
                conn.Close();
                conn.Dispose();
                return;
            }

            String Oraclecmd = "create table " + tablename + "(" + key + " " + "int primary key,"
                                                      + prop1 + " " + "int"
                                                       + ")";
            TextBox2.Text = Oraclecmd;
            NpgsqlCommand cmd = new NpgsqlCommand(Oraclecmd, conn);
            try
            {
                int r = cmd.ExecuteNonQuery();
                if (r == -1)
                {
                    TextBox1.Text = "创建表成功 ";
                }

            }
            catch (Exception ex)
            {
                TextBox1.Text = "创建表失败 " + ex.Message;
            }
            finally
            {
                conn.Close();
                //conn.Dispose();
               // cmd.Dispose();
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("../PostgreSqlTest.aspx");
        }



    }
}