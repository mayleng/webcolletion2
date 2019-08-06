using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCollection
{
    public partial class AbstractMethod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("抽象方法相关的用例！"+"</br>");

            AbstractChild cc = new AbstractChild();
            string a = "Duck  ";

            cc.Speak(ref a);
            cc.Run(ref a);

            Response.Write("a="+a+"</br>");

            string b = "Dog ";
            cc.Play(ref b);

            Response.Write("b="+b);

        }
    }
}