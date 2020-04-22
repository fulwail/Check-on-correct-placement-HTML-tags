using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using CheckEngine;
namespace CheckOnCorrectPlacement
{

    class Program
    {
        static void Main(string[] args)
        {
            IVerification verification = new Verification();
            Console.WriteLine("Введите Id для проверки");
          var searchResult=  verification.CheckOnCorrectPlacement("DatabaseSource");
            if (searchResult)
            {
                Console.WriteLine("Скобки были расставлены правильно");
            }
            else
            {
                Console.WriteLine("Скобки были расставлены не правильно!!!");
            }
            Console.ReadKey();
        }
    }

}

//{()<}>                 //false
//12 { 123 (1)asd}asd    // true
//]12 { 123 (1)asd}asd   // false
//12 { 123 (1)asd[]}asd  // true
//12 { 123 (1)as}d}asd   // false

