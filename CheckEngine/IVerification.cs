using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEngine
{
    public interface IVerification
    {
      
        bool CheckOnCorrectPlacement(string sourceType);
    }
}
