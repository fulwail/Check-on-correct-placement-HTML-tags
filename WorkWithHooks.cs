using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
  
        internal class WorkWithHooks
    {
        public bool CheckHooks(string text,Dictionary<string,string> dictionary)
        {
            string[] textRegex= Regex.Split(text, @"(<[^>]*>)");
            Dictionary<string, string> hookStorage = dictionary;   
            Stack<string> hook = new Stack<string>();     
            try
            {
                foreach (string ch in textRegex)
                {
                    if (hookStorage.Keys.Contains(ch)) hook.Push(ch);
                    
                    else if (hookStorage.Values.Contains(ch))
                    {
                        if (ch == hookStorage[hook.First()])  hook.Pop();
                        else
                        {
                            return false;
                        }
                    }
                    else continue;             
                }
            }
            catch
            {   
                return false;
            }
            if (hook.Count == 0) return true;
            else return false;
        }
    }
}