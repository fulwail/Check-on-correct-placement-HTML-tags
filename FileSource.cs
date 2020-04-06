using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp1
{
    class FileSource : ISource
    {   
        public string ReadSource(string context)
        {
            using (StreamReader sr = new StreamReader(context))
                return sr.ReadToEnd();
        }

        public void WriteToDestination(bool searchresult, string context,int count)
        {
            string path = context;
            using (StreamWriter sw = File.AppendText(path))
                sw.WriteLine(searchresult + "/число лексем: " + count);
        }
    }

}


