
using SqlDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject.Model;
namespace DataTransferObject
{
    public class DataService
    { 
        public IEnumerable<ResultOfCheckingDto> GetChekingResult()
        {
            var db = new DatabaseContext();
            var result = from r in db.ResultOfCheckings
                         select new ResultOfCheckingDto()
                         {
                             Id = r.Id,
                             DateTime = r.DateTime,
                             Result = r.Result,
                             CountToken = r.CountToken
                         };
                return result;    
        }
    }
}
