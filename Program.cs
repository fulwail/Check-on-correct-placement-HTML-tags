using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace CheckOnCorrectPlacement
{

    class Program
    {
        static void Main(string[] args)
        {
            IVerification verification = new Verification();
            verification.CheckOnCorrectPlacement("DatabaseSource");
            Console.ReadKey();
        }
    }

}

//{()<}>                 //false
//12 { 123 (1)asd}asd    // true
//]12 { 123 (1)asd}asd   // false
//12 { 123 (1)asd[]}asd  // true
//12 { 123 (1)as}d}asd   // false

