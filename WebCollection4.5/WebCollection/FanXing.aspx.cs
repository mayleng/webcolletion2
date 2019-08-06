using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection 
{
    public partial class FanXing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            string c = "nihao";
            string d = "hello";

           

            Response.Write("int 类型 ：a="+a.ToString()+",b="+b.ToString()+ "<br/>");

            ChangeNum<int>(ref a, ref b);
            Response.Write("int 类型 ：a=" + a.ToString() + ",b=" + b.ToString() + "<br/>");

            ChangeNum(ref c, ref d);
            Response.Write("string  类型 ：c=" +c + ",d=" + d+ "<br/>");


        }



        //泛型方法是使用类型参数声明的方法  泛型方法
        static void ChangeNum<T>(ref T lhs, ref T rhs)
        {
            T temp;
            Thread.Sleep(100);
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }


        //带有约束的泛型方法
        void ChangeNumGreater<T>(ref T lhs, ref T rhs) where T : System.IComparable<T>
        {
            T temp;
            Thread.Sleep(100);
            if (lhs.CompareTo(rhs) > 0)
            {
                temp = lhs;
                lhs = rhs;
                rhs = temp;
            }
        }

        //定义一个使用泛型参数的方法
       public void  GenericMeth<T>(List<T> list)
        {
            Thread.Sleep(100);
            foreach (var i in list)
            {
                Response.Write(i+"   ");
            }
            Response.Write("<br/>");
        }


        //泛型参数
        protected void Button1_Click(object sender, EventArgs e)
        {
            List<int> list1= new List<int>();
            list1.AddRange(new int[] { 1, 3, 5, 7, 9 });

            GenericMeth<int>( list1);

            List<double> list2 = new List<double>();
            list2.AddRange(new double[] { 1.6, 3.8, 5.9, 7.7, 9.585 });
            GenericMeth<double>(list2);
        }

        //泛型类
        protected void FanxingClass(object sender, EventArgs e)
        {
            // 声明一个整型数组
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            Thread.Sleep(100);
            // 设置值
            for (int c = 0; c < 5; c++)
            {
                intArray.setItem(c, c * 5);
            }
            // 获取值
            for (int c = 0; c < 5; c++)
            {
                Response.Write(intArray.getItem(c) + " ");
            }
            Response.Write("<br/>");

            // 声明一个字符数组
            MyGenericArray<char> charArray = new MyGenericArray<char>(5);
            Thread.Sleep(100);

            // 设置值
            for (int c = 0; c < 5; c++)
            {
                charArray.setItem(c, (char)(c + 97));
            }
            // 获取值
            for (int c = 0; c < 5; c++)
            {
               Response.Write(charArray.getItem(c) + " ");
            }
            Response.Write("<br/>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

    }



}