using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatUnitStudio
{
    public class PrepareTextClass
    {
        public static string PrepareText(string text)
        {
            text = text.Replace("\n", "");
            text = text.Replace("\t", "");
            text = text.Replace("\r", "");
            return text;
        }
    }
}
