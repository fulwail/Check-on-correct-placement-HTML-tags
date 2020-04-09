using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Director
    {
        private IBuilder _configuration;
        public IBuilder ConfigurationBuilder
        {
            set { _configuration = value; }
        }
        public void BuildFromFileSource()
        {
            _configuration.BuildInputPath();
            _configuration.BuildOutputPath();
            _configuration.BuildDictionaryToken();
            _configuration.BuildExceptionFileSource();
        }
       
        public void BuildFromDatabase()
        {
            _configuration.GetId();
            _configuration.BuildDictionaryToken();
            _configuration.BuildExceptionDatabase();
        }

    }
}
