using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace CheckOnCorrectPlacement
{
   public class Verification : IVerification
    {
        public string InputData { get; set; }

        public void CheckOnCorrectPlacement(string sourceType)
        {

            var container = ContainerConfig.Configure();
          
            using (var scope = container.BeginLifetimeScope())
            {
                var director = new Director();
                var builder = new ConfigurationBuilder();
                director.ConfigurationBuilder = builder;

                var source = scope.ResolveNamed<ISource>(sourceType);
                director.BuildForSource(source);
                var config = builder.GetProduct();
        
                WorkWithHooks hook = new WorkWithHooks();
                string text;
                try
                {
                    text = source.ReadSource(InputData);
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"{config.ExceptionText} {ex.Message}");
                    return;
                }
                bool searchResult = hook.CheckHooks(text, config.HooksStorage);
                try
                {
                    source.WriteToDestination(searchResult, hook.count);
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Описание ошибки при выводе результатов проверки:{ex.Message}");
                    return;
                }
               
                Console.WriteLine(config.ListParts());

                if (searchResult)
                {
                    Console.WriteLine(text + "\n Скобки были расставлены правильно");
                }
                else
                {
                    Console.WriteLine(text + " \n Скобки были расставлены не правильно!!!");
                }
            }
           
        }
    }
}
