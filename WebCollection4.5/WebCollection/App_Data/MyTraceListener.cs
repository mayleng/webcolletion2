using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.IO;

namespace WebCollection
{
    public class MyTraceListener: TraceListener
    {
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public MyTraceListener(string filePath)
        {
          FilePath = filePath;
        }

        public override void Write(string message)
        {
            File.AppendAllText(FilePath, message);
        }

        public override void WriteLine(string message)
        {
            File.AppendAllText(FilePath, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + message + Environment.NewLine);
        }
    }
}