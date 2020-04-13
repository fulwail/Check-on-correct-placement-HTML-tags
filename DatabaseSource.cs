using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;
using DBCheckedTestCase;


namespace CheckOnCorrectPlacement
{
    class DatabaseSource : ISource
    {

       
        public string ReadSource(string context)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var database = db.TestСases;
                int id = Convert.ToInt32(context);
                string text = (from c in db.TestСases
                               where c.Id == id
                               select c.Text).SingleOrDefault();
                return text;
            }
           
        }

        public void WriteToDestination(bool searchresult, string context,int count)
        {
            
            using (DatabaseContext db = new DatabaseContext())
            {
              
                var result = new ResultOfChecking();
                result.IdTestCase = Convert.ToInt32(context);
                result.DateTime = DateTime.Now;
                result.Result = Convert.ToString(searchresult);
                result.CountToken = count;
                db.ResultOfCheckings.Add(result);
                db.SaveChanges();
            }
        }
    }
}
