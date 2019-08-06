using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection
{
    public partial class Database : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/PostgreSqlTest.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("/MongodbTest.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("/RedisTests.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Sqlserver.aspx"); 
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("/MemcacheTest.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("/AccessData.aspx"); 
        }
    }
}