using System.Collections.Generic;
using System;
using System.Linq;
using System.Configuration;

namespace ConsoleApp1
{

    public class ConfigurationBuilder : IBuilder
    {
        private ConfigurationContext _configuration;
     
        public ConfigurationBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._configuration = new ConfigurationContext();
        }
        public void GetId()
        {
            Console.WriteLine("Введите id тестового варианта");
            this._configuration.Id = Console.ReadLine();
        }
        public void BuildInputPath()
        {
            string path= ConfigurationManager.AppSettings["PathInput"];
            this._configuration.Add("Путь до файла: "+path);
            this._configuration.InputPath = path;
        }

        public void BuildOutputPath()
        {
            string path= ConfigurationManager.AppSettings["PathOutput"];
            this._configuration.Add("Местоположение файла с логами: "+path);
            this._configuration.OutputPath = path;
        }
       
        
        private void GetDictionaryTokenInternal(string beginTokenName, string endTokenName)
        {
            string[] beginWord = ConfigurationManager.AppSettings[beginTokenName].Split(new char[] { ' ' });
            string[] endWord = ConfigurationManager.AppSettings[endTokenName].Split(new char[] { ' ' });
            string token = "";
            Dictionary<string, string> hookStorage = new Dictionary<string, string>();
            for (int i = 0; i < beginWord.Count(); i++)
            {
                hookStorage.Add(beginWord[i], endWord[i]);
                token += beginWord[i] + ",";
            }
            this._configuration.Add("Проверено на комбинацию лексем: " + token);
            this._configuration.HooksStorage = hookStorage;
        }
        public void BuildDictionaryToken()
        {
            GetDictionaryTokenInternal("BeginToken", "EndToken");
        }

        public ConfigurationContext GetProduct()
        {
            ConfigurationContext result = this._configuration;

            this.Reset();

            return result;          
        }
    }
}
