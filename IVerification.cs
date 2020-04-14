using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOnCorrectPlacement
{
    public interface IVerification
    {
        string InputData { get; set; }
        void CheckOnCorrectPlacement(string sourceType);
    }
}
