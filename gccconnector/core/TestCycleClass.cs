using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatUnitStudio
{
    public class TestCycleClass
    {
        TestFileClass testfile;
        List<string> funcNames;

        public TestCycleClass (TestFileClass testfile, List<string> funcNames)
        {
            this.testfile = testfile;
            this.funcNames = funcNames;
        }

        public async Task<List<TestResultClass>> RunTest() // 
        {
            List<TestResultClass> testResult = new List<TestResultClass>();

            for(int i = 0; i < funcNames.Count; i++)
            {
                PrepareDirectoryClass.Prepare(); // Подготавливаем директорию для работы
                CreatePatternFileClass.CreateFile(testfile.PathToFile, funcNames[i]);
                GccRunnetClass GccRunnet = new GccRunnetClass();
                GccRunnet.SendCommand("CD /d " + Directory.GetCurrentDirectory());
                GccRunnet.SendCommand(Directory.GetCurrentDirectory() + "\\mingw\\bin\\gcc.exe" + " testrunner.c");
                GccRunnet.SendCommand("a");
                GccRunnet.SendCommand("Exit");
                testResult.Add( await CheckResultClass.CheckResult(funcNames[i]));
                ClearAssertResultFileClass.Clear(funcNames[i]);
            }
            return testResult;
        }
    }
}
