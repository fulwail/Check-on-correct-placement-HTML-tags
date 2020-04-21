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
   public class VerificationWeb : IVerification
    {
        public bool searchResult { get; set; }
        public void CheckOnCorrectPlacement(string text)
        {
            ConfigurationHelper helper = new ConfigurationHelper();
            WorkWithHooks hook = new WorkWithHooks();
            searchResult = hook.CheckHooks(text, helper.GetDictionaryTokenInternal("BeginToken", "EndToken"));
            DataServiceContext dataService = new DataServiceContext();
            dataService.AddResultOfCheking(searchResult, hook.count);
        }
      
    }
}

