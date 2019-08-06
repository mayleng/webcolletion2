using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebCollection
{
    /// <summary>
    /// TestStore 的摘要说明
    /// </summary>
    public class TestStore : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentType = "text/html";
            // context.Response.Write("Hello World");
            string filepath = context.Request.MapPath("/TestStore/Index.html");
            string strhtml = File.ReadAllText(filepath);
            strhtml = strhtml.Replace("$name", "张三");
            Thread.Sleep(500);
            context.Response.Write(strhtml);




        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}