using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOnCorrectPlacement
{
   public interface ISource
    {
        string ReadSource(string context);
        void WriteToDestination(bool searchresult, string context, int count);
    }
}
