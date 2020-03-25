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
        public string ReadSource(string source)
        {
            using (StreamReader sr = new StreamReader(source))
                return sr.ReadToEnd();
        }

        public void WriteToDestination(string text, string source)
        {
            ConfigurationHelper use = new ConfigurationHelper();
            string path = use.GetOutputPath();
            using (StreamWriter sw = File.AppendText(path))
                sw.WriteLine(text);
        }
    }

}


