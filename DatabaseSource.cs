using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;


namespace ConsoleApp1
{
    class DatabaseSource : ISource
    {
        public string ReadSource(string context)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var database = db.TestСase;
                Dictionary<int, string> testCase = new Dictionary<int, string>();
                foreach (TestСases test in database)
                {
                    testCase.Add(test.Id, test.Text);
                }
            
                return testCase[Convert.ToInt32(context)];
            }
        }

        public void WriteToDestination(bool searchresult, string context,int count)
        {
            
            using (DatabaseContext db = new DatabaseContext())
            {
              
                var result = new ResultOfCheckings();
                result.IdTestCase = Convert.ToInt32(context);
                result.DateTime = DateTime.Now;
                result.Result = Convert.ToString(searchresult);
                result.CountToken = count;
          
            //    ResultOfCheckings result = new ResultOfCheckings { Id = 1, TestCase_Id = Convert.ToInt32(context), DateTime= DateTime.Now, Result = Convert.ToString(searchresult ), CountToken=0 };
                db.ResultOfChecking.Add(result);
                db.SaveChanges();
            }
        }
    }
}
