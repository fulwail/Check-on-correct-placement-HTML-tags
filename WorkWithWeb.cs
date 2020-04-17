using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService;

namespace CheckOnCorrectPlacement
{
   public class WorkWithWeb
    {

        private Dictionary<string, string> GetDictionaryTokenInternal()
        {
            string[] beginWord = ConfigurationManager.AppSettings["BeginToken"].Split(new char[] { ' ' });
            string[] endWord = ConfigurationManager.AppSettings["EndToken"].Split(new char[] { ' ' });
            string token = "";
            var hookStorage = new Dictionary<string, string>();
            for (int i = 0; i < beginWord.Count(); i++)
            {
                hookStorage.Add(beginWord[i], endWord[i]);
                token += beginWord[i] + ",";
            }
            return hookStorage;
        }
        public void CheckOnCorrectPlacement(string text)
        {
            WorkWithHooks hook = new WorkWithHooks();
            bool searchResult = hook.CheckHooks(text,  GetDictionaryTokenInternal());
            DataServiceContext dataService = new DataServiceContext();
            dataService.WriteToDestination(searchResult, hook.count);
        }
        public string ReadText(string path)
        {
            using (StreamReader sr = new StreamReader(path))
                return sr.ReadToEnd();
        }
    }
}

