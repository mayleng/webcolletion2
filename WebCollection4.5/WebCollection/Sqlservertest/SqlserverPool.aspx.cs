using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //数据库连接池相关



namespace WebCollection.Sqlservertest
{
    public partial class SqlserverPool : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 创建SqlConnection对象连接Northwind数据库

            // 设定连接池的允许最大连接数为5，最小连接数为2

            SqlConnection mySqlConnection =

                new SqlConnection(

                "server=192.168.1.247;database=Moon;uid=sa;pwd=may123;" +

                "max pool size=5;min pool size=2"

                );

            // 打开数据库连接5次   
            for (int count = 1; count <= 5; count++)
            {
                Response.Write("count = " + count + "</br>");

                // 记录当前时间
                DateTime start = DateTime.Now;

                // 打开数据库连接
                try
                {
                    mySqlConnection.Open();
                    string sql = "select  *  from  cute where age =2";
                    SqlCommand cmd = new SqlCommand(sql, mySqlConnection);
                    SqlDataReader myreader = cmd.ExecuteReader();
                    bool n  = myreader.Read();
                    Response.Write(n+"</br>");
                }
                catch 
                {
                    Response.Write("<script>alert('查询数据库失败!')</script>");
                }
                // 计算并显示连接的时间
                TimeSpan timeTaken = DateTime.Now - start;
                Response.Write("Milliseconds = " + timeTaken.Milliseconds + "</br>");

                // 显示连接状态
                Response.Write("mySqlConnection.State = " +
                    mySqlConnection.State+"</br>");

                //关闭连接
                mySqlConnection.Close();



            }
        }

    }
}
