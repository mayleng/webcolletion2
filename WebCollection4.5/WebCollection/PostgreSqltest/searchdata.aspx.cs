using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Text;
using Npgsql;
using System.Data;

namespace WebCollection.PostgreSqltest
{
    public partial class searchdata : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsearchdata(object sender, EventArgs e)
        {
            String tablename = tb0.Text.Trim();
            String prop = tb1.Text.Trim();
            String val = tb2.Text.Trim();

            NpgsqlConnection conn = new NpgsqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PostgreSqlConStr"].ConnectionString.ToString());
            conn.Open();

            String Oraclecmd = "SELECT * FROM " + tablename +"  where  "+prop +"="+val ;
            Response.Write(Oraclecmd+";           *******");
            NpgsqlCommand cmd = new NpgsqlCommand(Oraclecmd, conn);
            try
            {
                NpgsqlDataReader myreader = cmd.ExecuteReader();
                int count = 0;
                while (myreader.Read())
                {
                    TextBox1.Text = "查询成功！";
                    Response.Write("\r\n");
                    Response.Write(myreader.GetInt32(0));
                    count++;
                }
                myreader.Close();
                if (count == 0)
                {
                    TextBox1.Text = "写错啦!";
                    throw new Exception("写错啦!");
                }

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(Oraclecmd, conn);
                DataSet dataset = new DataSet();
                da.Fill(dataset, tablename);
                dtg.DataSource = dataset.Tables[tablename];
            }
            catch (Exception ex)
            {
                TextBox1.Text = "查询失败！" + ex.Message;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    //conn.Dispose();
                }
                if (cmd != null)
                {
                    //cmd.Dispose();
                }

            }
            dtg.DataBind();
        }

        protected void btnback(object sender, EventArgs e)
        {
            Response.Redirect("../PostgreSqlTest.aspx");
        }
        protected void dtg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}