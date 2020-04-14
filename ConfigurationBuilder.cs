using System.Collections.Generic;
using System;
using System.Linq;
using System.Configuration;
using System.IO;

namespace CheckOnCorrectPlacement
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
        
        public void BuildInputPath()
        {
            string path= ConfigurationManager.AppSettings["PathInput"];
            this._configuration.Add("Путь до файла: "+path);
            this._configuration.InputSource = path;
        }

        public void BuildOutputPath()
        {
            string path= ConfigurationManager.AppSettings["PathOutput"];
            this._configuration.Add("Местоположение файла с логами: "+path);
            this._configuration.OutputSource = path;
        }
        public void BuildExceptionDatabase()
        {
            string Excp = ConfigurationManager.AppSettings["ExceptionDatabase"];
            this._configuration.Add("Описание ошибки получения входного ресурса: " + Excp);
            this._configuration.ExceptionText = Excp;
        }
        public void BuildExceptionFileSource()
        {
            string Excp = ConfigurationManager.AppSettings["ExceptionFileSource"];
            this._configuration.Add("Описание ошибки получения входного ресурса: " + Excp);
            this._configuration.ExceptionText = Excp;
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
