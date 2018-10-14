using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace CatUnitStudio
{
    public class SaveResultClass
    {
        public async static void SaveResultTxt(List<TestResultClass> results, string name)
        {
            string NameTestFile = "Тестовый файл: " + name;
            string Header = "Дата: " + DateTime.Now.ToString();
            string CountTest = "Тестов: " + results.Count.ToString();
            string ResultAllTest = "Успешно: " + results.FindAll(x => x.Result == true).Count.ToString() + ", с ошибками: " + results.FindAll(x => x.Result == false).Count.ToString();
            string[] RowsToWrite = { NameTestFile, Header, CountTest, ResultAllTest };
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Test Result Txt|*.txt";
            if(sf.ShowDialog() == true)
            {
                using (FileStream fs = new FileStream(sf.FileName, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (string row in RowsToWrite)
                        {
                            await sw.WriteLineAsync(row);
                        }
                        sw.Close();
                    }
                    fs.Close();
                }
            }
        }
    }
}
