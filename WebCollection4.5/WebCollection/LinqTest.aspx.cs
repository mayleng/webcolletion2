using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection
{
    public partial class LinqTest : System.Web.UI.Page
    {
        //学生结构体
        struct Student
        {
            public string name;

            public int age;

            public int grade;

            public float score;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            var numQuery =
                  from num in numbers
                  where (num % 2) == 0
                  select num;

            foreach (int num in numQuery)
            {
                Response.Write(num + " 、");
            }
            Response.Write("<br/>");
        }

        //返回
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        //基本查询
        protected void Button2_Click(object sender, EventArgs e)
        {
            List<Student> listStudents = new List<Student>();
            Random pRandom = new Random();
            for (int i = 1; i < 50; i++)
            {
                float sc = pRandom.Next(0, 100);
                int age = pRandom.Next(8, 13);
                int gde = pRandom.Next(1, 6);

                string name = "";
                switch (pRandom.Next(0, 6))
                {
                    case 1: name = "周xxx"; break;
                    case 2: name = "李xxx"; break;
                    case 3: name = "孙xxx"; break;
                    case 4: name = "钱xxx"; break;
                    default: name = "赵xxx"; break;
                }
                Student psdt = new Student();
                psdt.name = name;
                psdt.age = age;
                psdt.grade = gde;
                psdt.score = sc;
                listStudents.Add(psdt);

            }
            //从50个学生中选择出不及格的人员名单并按分数降序排列
            var query = from r in listStudents where r.score < 60 orderby r.score descending select r;
            Response.Write("不及格的人员名单：" + "<br/>");
            foreach (Student st in query)
            {
                Response.Write("姓名：" + st.name + " &nbsp;&nbsp;&nbsp;");
                Response.Write("班级：" + st.grade + "&nbsp;&nbsp;&nbsp; ");
                Response.Write("年龄：" + st.age + "&nbsp;&nbsp;&nbsp; ");
                Response.Write("分数：" + st.score + " &nbsp;&nbsp;&nbsp;");
                Response.Write("<br/>");
            }

        }

        //延迟查询  linq查询为延迟查询，只需构造一次查询语句，可以多次使用
        protected void Button3_Click(object sender, EventArgs e)
        {
            //构造查询数据
            List<string> lists = new List<string> { "Jack", "Pet", "Hant", "Li", "Kkk" };
            var query = from r in lists where r.StartsWith("J") select r;
            Response.Write("第一次查询结果：" + "<br/>");
            foreach (string st in query)
            {
                Response.Write(st);
            }
            Response.Write("<br/>");

            Response.Write("第二次查询结果：" + "<br/>");
            lists.Add("Jone");
            lists.Add("Jimi");
            lists.Add("Johu");

            foreach (string st in query)
            {
                Response.Write(st + "  、");
            }

        }

        //类型筛选  利用OfType方法可以把特定类型数据筛选出来
        protected void Button4_Click(object sender, EventArgs e)
        {
            object[] pList = new object[] { 1, "one", 2, "two", 3, "three" };
            var query = pList.OfType<string>();
            foreach (var st in query)
            {
             Response.Write(st+" 、");
            }

        }

        //复合的from子句
        protected void Button5_Click(object sender, EventArgs e)
        {
            List<Student> listStudents = new List<Student>();
            Random pRandom = new Random();
            for (int i = 1; i < 50; i++)
            {
                float sc = pRandom.Next(0, 100);
                int age = pRandom.Next(8, 13);
                int gde = pRandom.Next(1, 6);

                string name = "";
                switch (pRandom.Next(0, 6))
                {
                    case 1: name = "周xxx"; break;
                    case 2: name = "李xxx"; break;
                    case 3: name = "孙xxx"; break;
                    case 4: name = "钱xxx"; break;
                    default: name = "赵xxx"; break;
                }
                Student psdt = new Student();
                psdt.name = name;
                psdt.age = age;
                psdt.grade = gde;
                psdt.score = sc;
                listStudents.Add(psdt);
            }

            var query = from s in listStudents
                        from n in s.name
                        where n == '赵'
                        orderby s.score descending
                        select s.grade + "班-" + s.name + "，分数" + +s.score;
            /*查询出所有姓赵的学生的班级、姓名、分数信息，并按分数由高到低排序*/
            foreach (var t in query)
            {
               Response.Write(t+" 、");
            }

        }

        //多级排序
        protected void Button6_Click(object sender, EventArgs e)
        {
            List<Student> listStudents = new List<Student>();
            Random pRandom = new Random();
            for (int i = 1; i < 50; i++)
            {
                float sc = pRandom.Next(0, 100);
                int age = pRandom.Next(8, 13);
                int gde = pRandom.Next(1, 6);

                string name = "";
                switch (pRandom.Next(0, 6))
                {
                    case 1: name = "周xxx"; break;
                    case 2: name = "李xxx"; break;
                    case 3: name = "孙xxx"; break;
                    case 4: name = "钱xxx"; break;
                    default: name = "赵xxx"; break;
                }

                Student psdt = new Student();
                psdt.name = name;
                psdt.age = age;
                psdt.grade = gde;
                psdt.score = sc;
                listStudents.Add(psdt);
            }

            var query = from s in listStudents orderby s.score, s.grade, s.age, s.name select s;

            foreach (Student st in query)
            {
                Response.Write("姓名：" + st.name);
                Response.Write("班级：" + st.grade);
                Response.Write("年龄：" + st.age);
                Response.Write("分数：" + st.score);
                Response.Write("<br/>");
            }

        }

     
    }
}