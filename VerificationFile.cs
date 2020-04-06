using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VerificationFile: IVerification
    {

        
        public void CheckOnCorrectPlacement(ConfigurationContext context)
        {

            WorkWithHooks hook = new WorkWithHooks();
            ISource file = new FileSource();
            string text;
            try
            {
                text = file.ReadSource(context.InputPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Не удалось прочитать файл: {ex.Message}");
                return;
            }
            bool searchResult = hook.CheckHooks(text, context.HooksStorage);
            file.WriteToDestination(searchResult, context.OutputPath, hook.count);

            if (searchResult)
            {
                Console.WriteLine(text+"\n Скобки были расставлены правильно");
            }
            else
            {
                Console.WriteLine(text+ " \n Скобки были расставлены не правильно!!!");             
            }

        }
    }
}
