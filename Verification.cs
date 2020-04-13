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
    class Verification : IVerification
    {

        public void CheckOnCorrectPlacement( )
        {
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var director = new Director();
                var builder = new ConfigurationBuilder();
                director.ConfigurationBuilder = builder;

                var source = scope.Resolve<ISource>();
                director.BuildForSource(source);
                var config = builder.GetProduct();

                WorkWithHooks hook = new WorkWithHooks();
                string text;
                try
                {
                    text = source.ReadSource(config.InputSource);
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"{config.ExceptionText} {ex.Message}");
                    return;
                }
                bool searchResult = hook.CheckHooks(text, config.HooksStorage);
                source.WriteToDestination(searchResult, config.OutputSource, hook.count);

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
