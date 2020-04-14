using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;
using SqlDatabase;

namespace CheckOnCorrectPlacement
{
    class FileSource : ISource
    {
        public string ReadSource(string context)
        {
            using (StreamReader sr = new StreamReader(context))
            return sr.ReadToEnd();
        }


        public void WriteToDestination(bool searchresult, int count)
        {
            //ConfigurationContext context = new ConfigurationContext();
            //string path = context.InputSource;
            //using (StreamWriter sw = File.AppendText(path))
            //    sw.WriteLine(searchresult + "/число лексем: " + count);
            using (DatabaseContext db = new DatabaseContext())
            {
                var result = new ResultOfChecking();
                result.DateTime = DateTime.Now;
                result.Result = Convert.ToString(searchresult);
                result.CountToken = count;
                db.ResultOfCheckings.Add(result);
                db.SaveChanges();
            }
        }
    }

}


  //  https://metanit.com/sharp/aspnet5/21.3.php



