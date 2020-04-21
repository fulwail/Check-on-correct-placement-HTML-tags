using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;
using SqlDatabase.Model;
using SqlDatabase;

namespace CheckOnCorrectPlacement
{
  public  class FileSource : ISource
    {
        public string ReadSource(string context)
        {
            using (StreamReader sr = new StreamReader(context))
            return sr.ReadToEnd();
        }

        public void WriteToDestination(bool searchresult, int count)
        {
            ConfigurationContext context = new ConfigurationContext();
            string path = context.InputSource;
            using (StreamWriter sw = File.AppendText(path))
                sw.WriteLine(searchresult + "/число лексем: " + count);

        }
    }

}





