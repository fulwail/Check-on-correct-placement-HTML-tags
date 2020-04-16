using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.Model
{
    public class ResultOfCheckingDto 
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Result { get; set; }
        public int CountToken { get; set; }
    }
}
