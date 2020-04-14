using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using SqlDatabase;

namespace CheckOnCorrectPlacement
{
    public class DataService<SqlDatabase>
    {
        public List<ResultOfChecking> GetChekingResult()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var results = (from c in db.ResultOfCheckings select c).ToList();

                return results;
            }


        }
    }
}


