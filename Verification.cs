using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ConsoleApp1
{
    class Verification : IVerification
    {

        public void CheckOnCorrectPlacement(ConfigurationContext context,string source )
        {
            string text;
            var container = ContainerConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.ResolveNamed<ISource>(source);

                var kernel = new StandardKernel();
                kernel.Load(Assembly.GetExecutingAssembly());
                WorkWithHooks hook = new WorkWithHooks();
                try
                {
                    text = app.ReadSource(context.InputSource);

                }

                catch (Exception ex)
                {
                    Console.WriteLine($"{context.ExceptionText} {ex.Message}");
                    return;
                }
                bool searchResult = hook.CheckHooks(text, context.HooksStorage);
                app.WriteToDestination(searchResult, context.OutputSource, hook.count);

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
