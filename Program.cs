using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

          
            var director = new Director();
            var builder = new ConfigurationBuilder();
            director.ConfigurationBuilder = builder;

            IVerification verification = new Verification();

            director.BuildFromFileSource();
            var configuration = builder.GetProduct(); 
            verification.CheckOnCorrectPlacement(configuration, "FileSource");

            Console.WriteLine(configuration.ListParts());

            director.BuildFromDatabase();
            configuration = builder.GetProduct();
            verification.CheckOnCorrectPlacement(configuration, "DatabaseSource");

            Console.WriteLine(configuration.ListParts());
            Console.ReadKey();
        }
    }

}

//{()<}>                 //false
//12 { 123 (1)asd}asd    // true
//]12 { 123 (1)asd}asd   // false
//12 { 123 (1)asd[]}asd  // true
//12 { 123 (1)as}d}asd   // false

