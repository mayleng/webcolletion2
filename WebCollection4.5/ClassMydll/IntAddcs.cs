using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassMydll
{
   public class IntAddcs
    {
        public  int IntTest(int a)
        {
            Thread.Sleep(20);

            try
            {
                int n = 1;
                int s = 0;
                for (n = 1; n <= a; n++)
                {
                    s += n;
                }
                return s;
            }
            catch (Exception ex)
            {
                string ss = ex.Message;
                ss += "error";
                return 404;
            }
           
        }
    }
}
