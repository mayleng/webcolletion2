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
    public partial class create_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCreate_Add(object sender, EventArgs e)
        {
            string responseText = string.Empty;

            string collection = TextBox1.Text.Trim();//集合名
            string key1 = TextBox2.Text.Trim(); string val1 = TextBox3.Text.Trim();
            string key2 = TextBox4.Text.Trim(); string val2 = TextBox5.Text.Trim();
            string key3 = TextBox6.Text.Trim(); string val3 = TextBox7.Text.Trim();

            string Mongoconstr = ConfigurationManager.AppSettings["mongodb"].ToString();
            string database = ConfigurationManager.AppSettings["mongodatabase"].ToString();

            //建立连接
            MongoClient monclient = new MongoClient(Mongoconstr);
          
            //建立数据库
            IMongoDatabase mondb = monclient.GetDatabase(database);
           
            try
            {
                var document = new BsonDocument
                            {
                                {key1,val1},
                                {key2,val2},
                                {key3,val3},
                            };
                //创建集合
                var coll = mondb.GetCollection<BsonDocument>(collection);
               
              coll.InsertOne(document);
             

                //再写一个插入
                var document2 = new BsonDocument("x", 126);
                coll.InsertOneAsync(document2);

                //同时插入多条语句
                var documents = Enumerable.Range(0, 10).Select(i => new BsonDocument("x", i));
                coll.InsertMany(documents);

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