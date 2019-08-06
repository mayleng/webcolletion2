using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebCollection
{
    //自定义一个接口
    public interface IMytest2
    {
        int MyInterfaceMethod3();
        string MyInterfaceMethod4();
    }


    //创建该类 用来测试继承接口
    public class InterBase:IMytest2
    {
        

        public int MyInterfaceMethod3()
        {
            Thread.Sleep(20);
            return 456;
        }

        public string MyInterfaceMethod4()
        {
            Thread.Sleep(20);
            return "Interface Test";
        }
    }
}