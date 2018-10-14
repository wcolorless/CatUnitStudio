using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace CatUnitStudio
{
    public class CheckResultClass
    {
        public async static Task<TestResultClass> CheckResult(string name)
        {
            string fileResultOK = Directory.GetCurrentDirectory() + "\\" + name + ".ok";
            string fileResultError = Directory.GetCurrentDirectory() + "\\" + name + ".er";
            Thread.Sleep(800);
            bool result = File.Exists(fileResultOK) || File.Exists(fileResultError);

            if (File.Exists(fileResultOK))
            {
                string Message = "";
                using (FileStream fs = new FileStream(fileResultOK, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1251")))
                    {
                        Message = await sr.ReadToEndAsync();
                        sr.Close();
                    }
                    fs.Close();
                }
                return new TestResultClass(name, Message, true);
            }
            else if(File.Exists(fileResultError))
            {
                string Message = "";
                using (FileStream fs = new FileStream(fileResultError, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1251")))
                    {
                        Message = await sr.ReadToEndAsync();
                        sr.Close();
                    }
                    fs.Close();
                }
                return new TestResultClass(name, Message, false);
            }
            else   return new TestResultClass(name, "", false);
        }
    }
}
