using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebInterface.ViewModels
{ 
    public class ResultOfCheckingViewModel
    {
        public int Id { get; set; }
        public string DateTime { get; set; }
        public string Result { get; set; }
        public int CountToken { get; set; }
    }
}