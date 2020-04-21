
using SqlDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService.Model;
using SqlDatabase.Model;



namespace DataService
{
    public class DataServiceContext
    {
       
     
        public IEnumerable<ResultOfCheckingDto> GetResultOfCheckingDto()
        {
            var db = new DatabaseContext();
            var result = from r in db.ResultOfCheckings
                         select new ResultOfCheckingDto()
                         {
                             Id = r.Id,
                             DateTime = r.DateTime,
                             Result = r.Result,
                             CountToken = r.CountToken
                         };
                return result;    
        }
        public string GetTestCaseById(int id)
        {
            DatabaseContext db = new DatabaseContext();

            var database = db.TestСases;
            string text = (from c in db.TestСases
                           where c.Id == id
                           select c.Text).SingleOrDefault();
            return text;
        }


        public void AddResultOfCheking(bool searchresult, int count)
        {
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
