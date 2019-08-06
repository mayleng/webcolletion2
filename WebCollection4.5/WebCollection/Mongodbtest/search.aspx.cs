using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection.Mongodbtest
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchData(object sender, EventArgs e)
        {
            string responseText = string.Empty;

            string collection = TextBox1.Text.Trim();
            string key = TextBox2.Text.Trim(); string val = TextBox3.Text.Trim();

            string Mongoconstr = ConfigurationManager.AppSettings["mongodb"].ToString();
            string database = ConfigurationManager.AppSettings["mongodatabase"].ToString();
            var monclient = new MongoClient(Mongoconstr);
            //建立数据库
            IMongoDatabase mondb = monclient.GetDatabase(database);

            try
            {
                var coll = mondb.GetCollection<BsonDocument>(collection);

                var filter = new BsonDocument(key, val);
               

                var replacementDocument = new BsonDocument("FirstName", "John");
                var result1 = coll.FindOneAndReplace(filter, replacementDocument);

                var filter2 = new BsonDocument("FirstName", "John");
                var result = coll.FindOneAndDelete(filter2);


                responseText = "操作成功！";
            }
            catch (Exception ex)
            {
                responseText = "操作失败！" + ex.Message + ex.StackTrace;
            }

            Response.Write("<script>alert('" + responseText + "')</script>");
        }

        protected void btnBack(object sender, EventArgs e)
        {
            Response.Redirect("../MongodbTest.aspx");
        }
    }
}