using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatUnitStudio
{
    public class PrepareDirectoryClass
    {
        public static void Prepare()
        {
            string testRunnerFile = Directory.GetCurrentDirectory() + "\\testrunner.c";
            if (File.Exists(testRunnerFile)) File.Delete(testRunnerFile); // Если есть файл - удаляем его
            string executeTestFile = Directory.GetCurrentDirectory() + "\\a.exe";
            if (File.Exists(executeTestFile)) File.Delete(executeTestFile);
        }
    }
}
