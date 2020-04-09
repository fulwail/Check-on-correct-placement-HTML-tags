using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCheckedTestCase
{
    public class TestСases
    {

        public int Id { get; set; }
        public string Text { get; set; }
    }
    public class ResultOfCheckings
    {
        public int Id { get; set; }
        public int IdTestCase { get; set; }
        public DateTime DateTime { get; set; }
        public string Result { get; set; }
        public int CountToken { get; set; }

    }
}
