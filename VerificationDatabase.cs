using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VerificationDatabase : IVerification
    {
        public void CheckOnCorrectPlacement(ConfigurationContext context)
        {
            
            WorkWithHooks hook = new WorkWithHooks();
            ISource database = new DatabaseSource();
            string text;
            try
            {
               text = database.ReadSource(context.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Данный Id не был найден: {ex.Message}");
                return;
            }
            bool searchResult = hook.CheckHooks(text, context.HooksStorage);
            database.WriteToDestination(searchResult, context.Id, hook.count);

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
