using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection
{
    public partial class Recursion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("fanhui");
        }

        //调用阶乘方法
        protected void Button1_Click(object sender, EventArgs e)
        {
           int n = int.Parse(TextBox1.Text);
            string n1 = Factorial(n).ToString();
            TextBox2.Text = n1;
        }

        //递归方法（0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144）
        public long Factorial(int n)
        {
            if (n < 0) return -1;
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Factorial(n - 1) + Factorial(n - 2);
        }

        //返回
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}