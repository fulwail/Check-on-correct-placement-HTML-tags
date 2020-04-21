using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOnCorrectPlacement
{
    public class ConfigurationHelper
    {
        public Dictionary<string, string> GetDictionaryTokenInternal(string beginTokenName, string endTokenName)
        {
            string[] beginWord = ConfigurationManager.AppSettings[beginTokenName].Split(new char[] { ' ' });
            string[] endWord = ConfigurationManager.AppSettings[endTokenName].Split(new char[] { ' ' });
            var hookStorage = new Dictionary<string, string>();
            for (int i = 0; i < beginWord.Count(); i++)
            {
                hookStorage.Add(beginWord[i], endWord[i]);     
            }
            return hookStorage;
        }

    }
}
