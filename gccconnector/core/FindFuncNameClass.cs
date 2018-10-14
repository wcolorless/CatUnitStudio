using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatUnitStudio
{
    public class FindFuncNameClass
    {
        static int FindBracket(string text)
        {
            for(int i = 0; i < text.Count(); i++)
            {
                string new_text = text.Substring(i);
                if (new_text.First() == '(')
                {
                    char[] array_char = new_text.ToArray();
                    if (array_char[0] == '(' && array_char[1] == ')')
                    {
                        if(array_char[2] == '{') return i;
                    }
                }
                else if(new_text.First() == ';' || new_text.First() == '}')
                {
                    return -1;
                }
            }
            return -1;
        }

        public static List<string> Find(string text, int startIndex)
        {
            string funcName = "";
            string compareFunc = "";
            List<string> funcNameList = new List<string>();
            for(int i = 0; i < text.Count(); i++)
            {
                compareFunc = text.Substring(i);
                if(compareFunc.First() == 'T')
                {
                    if(compareFunc.StartsWith("Test_"))
                    {
                      int index = FindBracket(compareFunc);
                      if(index > -1)
                      {
                         funcName = compareFunc.Substring(0, index);
                         funcNameList.Add(funcName);
                      }
                    }
                }
            }
            return funcNameList;
        }
    }
}
