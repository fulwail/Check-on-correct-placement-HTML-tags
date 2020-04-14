using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlDatabase;

namespace CheckOnCorrectPlacement
{
    public class TestCaseEditor
    {
        public int AddTestcase(string context)
        {
            string text;
            int id;
            using (StreamReader sr = new StreamReader(context))
                text = sr.ReadToEnd();
            using (DatabaseContext db = new DatabaseContext())
            {
                var testCase = new TestСase();
                testCase.Text = text;
                db.TestСases.Add(testCase);
                id = testCase.Id;
                db.SaveChanges();
                return id;
            }
        }
    }
}
