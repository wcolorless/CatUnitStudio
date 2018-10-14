using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatUnitStudio
{
    public class CreatePatternFileClass
    {
        public static void CreateFile(string path, string funcName)
        {
            string newPathFile = Directory.GetCurrentDirectory() + "\\testrunner.c";
            string prefix = "#include " + '"' + path + '"';
            string[] allLines = { prefix, " ", "#include \"stdio.h\"", " ", "int main(void)", "{" , " ", funcName + "();" , " ", "return(0);", "};" };
            File.WriteAllLines(newPathFile, allLines);
        }
    }
}
