using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBCheckedTestCase
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DbConnection")
        { }

        public DbSet<ResultOfChecking> ResultOfCheckings { get; set; }
        public DbSet<TestСase> TestСases { get; set; }

    }
}
