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
            IVerification verification = new Verification();

            director.BuildForTokens();
            var product = builder.GetProduct();
            verification.CheckOnCorrectPlacement(product);
            Console.WriteLine(product.ListParts());

            director.BuildForTokens2();
            product = builder.GetProduct();
            verification.CheckOnCorrectPlacement(product);
            Console.WriteLine(product.ListParts());

            director.BuildForTokens3();
            product = builder.GetProduct();
            verification.CheckOnCorrectPlacement(product);
            Console.WriteLine(product.ListParts());

            Console.ReadKey();


        }
    }
}

//{()<}>                 //false
//12 { 123 (1)asd}asd    // true
//]12 { 123 (1)asd}asd   // false
//12 { 123 (1)asd[]}asd  // true
//12 { 123 (1)as}d}asd   // false