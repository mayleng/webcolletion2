using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection
{
    public partial class HttpWebRequests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            Response.Write("HttpWebRequest远程调用！");
        }

        //返回
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://baike.baidu.com/item/good/499438?fr=aladdin");
            req.Method = "GET";
            WebResponse wr = req.GetResponse();
            using (StreamReader reader = new StreamReader(wr.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }
           // Response.Write("Get Result"+wr.ToString());


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            string param = "city=apple";
            byte[] bs = Encoding.ASCII.GetBytes(param);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("Http://fanyi.baidu.com:80");
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = bs.Length;
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(bs, 0, bs.Length);

            HttpWebResponse response = (HttpWebResponse)req.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(40);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://192.168.0.178:8005/RemoteXiazuan.ashx?");
            req.Method = "GET";
            WebResponse wr = req.GetResponse();
            using (StreamReader reader = new StreamReader(wr.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }
        }

        //测试远程调用错误的页面
        protected void Button5_Click(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://192.168.0.178:8005/Error.aspx");
            req.Method = "GET";
            WebResponse wr = req.GetResponse();
            using (StreamReader reader = new StreamReader(wr.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }
        }

        //调用C业务
        protected void Button7_Click(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://192.168.0.198:8066/CTest.aspx");
            req.Method = "GET";
            WebResponse wr = req.GetResponse();
            using (StreamReader reader = new StreamReader(wr.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }
        }

        //调用B业务
        protected void Button6_Click(object sender, EventArgs e)
        {
            Thread.Sleep(30);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://192.168.0.178:8005/BTest.aspx");
            req.Method = "GET";
            WebResponse wr = req.GetResponse();
            using (StreamReader reader = new StreamReader(wr.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }
        }

        //调用Java业务
        protected void Button8_Click(object sender, EventArgs e)
        {
            Thread.Sleep(30);
        HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("http://192.168.0.170:8080/Test1/test/db/postgresql/testPostgresql");
            req.Method = "GET";
            WebResponse wr = req.GetResponse();
            using (StreamReader reader = new StreamReader(wr.GetResponseStream(), System.Text.Encoding.UTF8))
            {
                Response.Write(reader.ReadToEnd());
            }
        }
    }
}