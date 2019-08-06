using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassMydll;

namespace WebCollection
{
    public partial class SelfDll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int n = 1000;
            string s = "moon   ";

          IntAddcs a = new IntAddcs();
            n = a.IntTest(n);

            StringAdd b = new StringAdd();
            s = b.StrTest(s);

            Response.Write("n="+n.ToString()+"</br>"+"s="+s);
        }
    }
}