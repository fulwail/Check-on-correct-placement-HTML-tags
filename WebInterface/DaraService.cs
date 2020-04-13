using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBCheckedTestCase;

namespace WebInterface
{
    public class DaraService
    {
        public object results { get; set; }

        public void ReadDatabase()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var results = (from c in db.ResultOfCheckings select c).ToList();
                this.results = results;
            }
        }
    }
}

