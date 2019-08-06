using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Text;
using Npgsql;

namespace WebCollection.PostgreSqltest
{
    public partial class deletedata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btndeletedata(object sender, EventArgs e)
        {
            String tablename = t0.Text.Trim();
            String key = t1.Text.Trim();
            String keyval = t2.Text.Trim();

            NpgsqlConnection conn = new NpgsqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PostgreSqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Oraclecmd;
            NpgsqlCommand cmd;
            Oraclecmd = "delete from " + tablename + " where " + key + "=" + keyval;
            cmd = new NpgsqlCommand(Oraclecmd, conn);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    TextBox1.Text = "删除成功！";
                }
                else
                {
                    TextBox1.Text = "删除失败！";
                }
            }
            catch (Exception ex)
            {
                TextBox1.Text = "删除失败！" + ex.Message;
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
        protected void Button3_Click(object sender, EventArgs e)
        {
            String tablename = t0.Text.Trim();
            NpgsqlConnection conn = new NpgsqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PostgreSqlConStr"].ConnectionString.ToString());
            conn.Open();

            string Oraclecmd = "drop table " + tablename;
            NpgsqlCommand cmd = new NpgsqlCommand(Oraclecmd, conn);
            try
            {
                cmd.ExecuteNonQuery();
                TextBox2.Text = "删除成功！";
            }
            catch (Exception ex)
            {
                TextBox2.Text = "删除失败！" + ex.Message;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}