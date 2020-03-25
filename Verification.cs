using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Verification: IVerification
    {
        public void CheckOnCorrectPlacement()
        {
            WorkWithHooks hook = new WorkWithHooks();
            ISource file = new FileSource();
            ConfigurationHelper helper = new ConfigurationHelper();
            string text;
            try { 
                    
               text = file.ReadSource(helper.GetInputPath());
            }
            catch (Exception ex)
            {
                Console.WriteLine( $"Не удалось прочитать файл: {ex.Message}");
                return;
            }

            bool searchResult = hook.CheckHooks(text);
            file.WriteToDestination(text + "/ " + searchResult, helper.GetOutputPath());

            if (searchResult)
            {
                Console.WriteLine(text+"\n Скобки были расставлены правильно");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(text+ " \n Скобки были расставлены не правильно!!!");
                Console.ReadKey();
            }
        }
    }
}
