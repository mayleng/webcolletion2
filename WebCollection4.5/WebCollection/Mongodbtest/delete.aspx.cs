using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MongoDB.Bson;
using MongoDB.Driver;


namespace WebCollection.Mongodbtest
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeleData(object sender, EventArgs e)
        {
            string responseText = string.Empty;

            string collection = TextBox3.Text.Trim();
            string key = TextBox1.Text.Trim();
            string val = TextBox2.Text.Trim();

            string Mongoconstr = ConfigurationManager.AppSettings["mongodb"].ToString();
            string database = ConfigurationManager.AppSettings["mongodatabase"].ToString();
            var monclient = new MongoClient(Mongoconstr);

          
            //建立数据库
           
            IMongoDatabase mondb = monclient.GetDatabase(database);

            
            var coll = mondb.GetCollection<BsonDocument>(collection);
            try
            {

                var filter = new BsonDocument(key,val);
                var result = coll.DeleteOne(filter);


                //var result2 = coll.DeleteMany(filter);

                responseText = "操作成功！";
              
                
                   

            }
            catch (Exception ex)
            {
                Response.Write("操作失败！" + ex.Message + ex.StackTrace);
            }

            Response.Write("<script>alert('" + responseText + "')</script>");
        }

        protected void btnBack(object sender, EventArgs e)
        {
            Response.Redirect("../MongodbTest.aspx");
        }
    }
}