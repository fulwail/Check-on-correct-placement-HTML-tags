using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOnCorrectPlacement
{
    class Director
    {
        private IBuilder _configuration;
        public IBuilder ConfigurationBuilder
        {
            set { _configuration = value; }
        }
        public void BuildForFileSource()
        {
            _configuration.BuildInputPath();
            _configuration.BuildOutputPath();
            _configuration.BuildDictionaryToken();
            _configuration.BuildExceptionFileSource();
        }
       
        public void BuildFoDatabaseSource()
        {
            _configuration.BuildDictionaryToken();
            _configuration.BuildExceptionDatabase();  
        }
        public void BuildForSource(ISource source)
        {
            if (source is FileSource)
                BuildForFileSource();

            else if (source is DatabaseSource)
                BuildFoDatabaseSource();

            else throw new Exception("Неподдерживаемый источник данных");
        }

    }
}
