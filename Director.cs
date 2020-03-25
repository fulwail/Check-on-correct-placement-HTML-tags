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
        public void BuildForTokens ()
        {
            _configuration.BuildInputPath();
            _configuration.BuildOutputPath();
            _configuration.BuildDictionaryToken();

        }
        public void BuildForTokens2()
        {
            _configuration.BuildInputPath();
            _configuration.BuildOutputPath();
            _configuration.BuildDictionaryToken2();
        }
        public void BuildForTokens3()
        {
            _configuration.BuildInputPath();
            _configuration.BuildOutputPath();
            _configuration.BuildDictionaryToken3();
        }

    }
}
