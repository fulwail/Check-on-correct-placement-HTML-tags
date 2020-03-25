using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public interface ISource
    {
        string ReadSource(string source);
        void WriteToDestination(string text, string source);
    }
}
