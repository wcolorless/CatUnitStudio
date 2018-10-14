using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CatUnitStudio
{
    public class ClearAssertResultFileClass
    {
        public static void Clear(string FileName)
        {
            string OkFile = Directory.GetCurrentDirectory() + "\\" + FileName + ".ok";
            string ErrFile = Directory.GetCurrentDirectory() + "\\" + FileName + ".er";

            if (File.Exists(OkFile)) File.Delete(OkFile);
            if (File.Exists(ErrFile)) File.Delete(ErrFile);
        }
    }
}
