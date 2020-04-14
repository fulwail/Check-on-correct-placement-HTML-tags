using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOnCorrectPlacement
{
    interface IVerification
    {
        string InputData { get; set; }
        void CheckOnCorrectPlacement();
    }
}
