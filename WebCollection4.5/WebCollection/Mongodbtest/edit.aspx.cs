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
    public partial class edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEditData(object sender, EventArgs e)
        {
            string responseText = string.Empty;

            string collection = TextBox5.Text.Trim();
            string key1 = TextBox1.Text.Trim(); string val1 = TextBox2.Text.Trim();
            string key2 = TextBox3.Text.Trim(); string val2 = TextBox4.Text.Trim();

            string Mongoconstr = ConfigurationManager.AppSettings["mongodb"].ToString();
            string database = ConfigurationManager.AppSettings["mongodatabase"].ToString();
            var monclient = new MongoClient(Mongoconstr);
            //建立数据库
            IMongoDatabase mondb = monclient.GetDatabase(database);
            try
            {
                //创建集合
                var coll = mondb.GetCollection<BsonDocument>(collection);

                  var filter = new BsonDocument(key1, val1);
                var replace = new BsonDocument(key2, val2);

                //替换
                var result = coll.ReplaceOne(filter, replace);

                //更新
                var filter2 = new BsonDocument(key2, val2);
                var update = new BsonDocument("$set", new BsonDocument("x", 198));
                var options = new UpdateOptions { IsUpsert = true };
                var result2 = coll.UpdateOne(filter2, update, options);

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