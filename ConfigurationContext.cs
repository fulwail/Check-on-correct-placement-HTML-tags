using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CheckOnCorrectPlacement
{
    
    public class ConfigurationContext
    {
        public string InputSource { get; set; }

        public string OutputSource { get; set; }
        public string ExceptionText { get; set; }
        public Dictionary<string, string> HooksStorage { get; set; }

        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + "\n";
            }

            str = str.Remove(str.Length - 2);

            return "Использовалась следующие параметры конфигурация: \n" + str + "\n";
        }
    }
}
