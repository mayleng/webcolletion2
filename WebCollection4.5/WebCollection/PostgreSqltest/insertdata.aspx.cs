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
    public partial class insertdata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btninsertdata(object sender, EventArgs e)
        {
            String tablename = tt0.Text.Trim();
            String key = tt1.Text.Trim();
            String prop1 = tt2.Text.Trim();


            NpgsqlConnection conn = new NpgsqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PostgreSqlConStr"].ConnectionString.ToString());
            conn.Open();
            String Oraclecmd;
            NpgsqlCommand cmd;
            Oraclecmd = "insert into " + tablename + " values(" + key + "," + prop1 + ")";
            Response.Write(Oraclecmd);
            cmd = new NpgsqlCommand(Oraclecmd, conn);
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    TextBox1.Text = "添加成功！";
                }
                else
                {
                    TextBox1.Text = "添加失败！";
                }
            }
            catch (Exception ex)
            {
                TextBox1.Text = "添加失败！ " + ex.Message;
            }
            finally
            {
                conn.Close();
               // conn.Dispose();
                //cmd.Dispose();
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../PostgreSqlTest.aspx");
        }
    }
}