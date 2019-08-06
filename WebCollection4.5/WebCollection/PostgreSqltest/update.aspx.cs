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
    public partial class updata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../PostgreSqlTest.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string tablename = tableName.Text.Trim();
            string prop = pro.Text.Trim();
            string propvalue = provalue.Text.Trim();

            NpgsqlConnection conn = new NpgsqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PostgreSqlConStr"].ConnectionString.ToString());
            conn.Open();
            String Oraclecmd;
            NpgsqlCommand cmd;

            string propvalue2 = (Convert.ToInt32(propvalue) + 1).ToString();
            Oraclecmd = "update  " + tablename + " set " + prop + "=" + propvalue2 +  " where " +
                prop + "=" + propvalue;

            cmd = new NpgsqlCommand(Oraclecmd, conn);
            
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    TextBox4.Text = "修改成功！";
                    TextBox5.Text = Oraclecmd;
                }
                else
                {
                    TextBox4.Text = "修改失败！";
                }
            }
            catch (Exception ex)
            {
                TextBox4.Text = "修改失败！"+ex.Message;
            }
            finally
            {
                conn.Close();
                //conn.Dispose();
               // cmd.Dispose();
               
            }
        }
    }
}