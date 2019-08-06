using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassMydll
{
   public class StringAdd
    {
        public string StrTest(string a)
        {
            Thread.Sleep(20);
            int n = 0;
            for (int i = 0; i<=1000; i++)
            {              
                n += i;
            }
           
            try
            {
                string s = "  hello world!**";
                a = a + s;
                return a;
            }
            catch(Exception ex)
            {
                return "ERROR"+ex.Message;
            }
           
            
        }
    }
}
