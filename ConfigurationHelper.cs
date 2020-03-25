using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp1
{
    class ConfigurationHelper
    {
        public string GetInputPath() =>ConfigurationManager.AppSettings["PathInput"];
        public string GetOutputPath() => ConfigurationManager.AppSettings["PathOutput"];
        public Dictionary<string,string> GetDictionaryToken()
        {
            string[] beginWord = ConfigurationManager.AppSettings["BeginWord"].Split(new char[] { ' ' });  
            string[] endWord = ConfigurationManager.AppSettings["EndWord"].Split(new char[] { ' ' });
            Dictionary<string, string> hookStorage = new Dictionary<string, string>();
            for (int i = 0; i < beginWord.Count(); i++) hookStorage.Add(beginWord[i], endWord[i]);
            return hookStorage;
        }
    }
}
