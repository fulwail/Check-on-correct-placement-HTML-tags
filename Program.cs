using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            var director = new Director();
            var builder = new ConfigurationBuilder();
            director.ConfigurationBuilder = builder;
            IVerification verificationFile = new VerificationFile();
            director.BuildFromFileSource();
            var product = builder.GetProduct();
            verificationFile.CheckOnCorrectPlacement(product);
            Console.WriteLine(product.ListParts());

            IVerification verificationDB = new VerificationDatabase();
            director.BuildFromDatabase();
            product = builder.GetProduct();
            verificationDB.CheckOnCorrectPlacement(product);
            Console.ReadKey();
        }
    }

}

//{()<}>                 //false
//12 { 123 (1)asd}asd    // true
//]12 { 123 (1)asd}asd   // false
//12 { 123 (1)asd[]}asd  // true
//12 { 123 (1)as}d}asd   // false

