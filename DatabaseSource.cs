using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.IO;
using DataService;



namespace CheckOnCorrectPlacement
{
    public class DatabaseSource : ISource
    {

       
        public string ReadSource(string context)
        {
            DataServiceContext dataService = new DataServiceContext();
            string text = dataService.GetTestCaseById(Convert.ToInt32(context)); 
                return text;
        }
       

        public void WriteToDestination(bool searchresult,int count)
        {
            DataServiceContext dataService = new DataServiceContext();
           dataService.AddResultOfCheking(searchresult,count);
        }
    }
}
