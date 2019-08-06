using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection
{
    public partial class Try : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CacheTextBox.Text = Cache["key1"].ToString();
        }

        //自定义一个异常
        public void TestTry()
        {
            try
            {
                int a = 0;
                int c = 7 / a;
            }
            catch (Exception ex)
            {
                string messge = ex.Message;
                Response.Write("<script>alert('" + messge + "')</script>");

            }
        }

        //使用系统抛出异常
        public void TestTry2()
        {
            try
            {
                throw new Exception("Raise a exception.");
            }
            catch (Exception ex)
            {
                string messge = ex.Message;
                Response.Write("<script>alert('"+messge+"')</script>");
            }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                throw new ArgumentOutOfRangeException();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw new ArgumentOutOfRangeException();
            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TestTry();

            //获取URL中的参数
            string c = Request.QueryString["c"];
            int n = Convert.ToInt32(c);
            if (n < 10)
            {
                TestTry2();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                throw new SystemException();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
                throw new SystemException();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                throw new ApplicationException();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw new ApplicationException();
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw new ArgumentException();
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                throw new MemberAccessException();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw new MemberAccessException();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                throw new ArrayTypeMismatchException();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw new ArrayTypeMismatchException();
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                throw new IOException();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw new IOException();
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                throw new FileLoadException();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw new FileLoadException();
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                throw new ArithmeticException();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                throw new ArithmeticException();
            }
        }
    }
}