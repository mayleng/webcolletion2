using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCollection
{
    public class AbstractChild: AbstractClass
    {
        public override void Speak(ref string a)
        {
            a += "child speak!";
        }

        public override void Run(ref string b)
        {
            b += "child run!";
        }

        public override void Play(ref string c)
        {
            base.Play(ref c);
            c += "child play ";
        }
    }
}