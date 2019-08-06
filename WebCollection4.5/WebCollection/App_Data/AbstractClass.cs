using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCollection
{
    public abstract class AbstractClass
    {
        public abstract void Speak(ref string a);

        public abstract void Run(ref string b);

        public virtual void Play(ref string c)
        {
            c += "object play";
        }
    }
}