using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebCollection
{
    public partial class URL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(100);

            string userName = Request.QueryString["textName"];

            Response.Write("参数值为："+userName + "<br/>");

            if (userName == null)
            {                
                string ss = Request.Url.ToString();
                string ss1 = Request.UrlReferrer.ToString();

                Response.Write("当前请求URL为："+ss+"<br/>");
                Response.Write("上一次请求URL为：" + ss1);
            }

            else if (userName == "参数一")
            {
                string ss = Request.Url.ToString();
                string ss1 = Request.UrlReferrer.ToString();

                Response.Write("当前请求URL为：" + ss + "<br/>");
                Response.Write("上一次请求URL为：" + ss1);
            }

            else if (userName == "参数二")
            {
                string ss = Request.Url.ToString();
                string ss1 = Request.UrlReferrer.ToString();

                Response.Write("当前请求URL为：" + ss + "<br/>");
                Response.Write("上一次请求URL为：" + ss1);
            }
            else
            {
                string ss = Request.Url.ToString();
                string ss1 = Request.UrlReferrer.ToString();

                Response.Write("当前请求URL为：" + ss + "<br/>");
                Response.Write("上一次请求URL为：" + ss1);
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/URL.aspx?textName=参数一");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/URL.aspx?textName=参数二&testName=good");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/URL.aspx?textName=参数三&pwd=123456&key=world");
        }
    }
}