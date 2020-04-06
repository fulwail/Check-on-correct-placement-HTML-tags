using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IBuilder
    {
        void BuildInputPath();
        void BuildOutputPath();
        void BuildDictionaryToken();
        void GetId();

    }
}
