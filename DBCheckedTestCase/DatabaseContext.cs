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

        public DbSet<ResultOfCheckings> ResultOfChecking { get; set; }
        public DbSet<TestСases> TestСase { get; set; }

    }
}
