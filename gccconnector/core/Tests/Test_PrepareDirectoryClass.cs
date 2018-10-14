using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xunit;

namespace CatUnitStudio
{
    public class Test_PrepareDirectoryClass
    {
        [Fact]
        public void Test_PrepareDirectory()
        {
            using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\testrunner.c", FileMode.Create, FileAccess.Write))
            {
                fs.Write(new byte[] { 0, 1, 2 }, 0, 3);
                fs.Close();
            }
            using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\a.exe", FileMode.Create, FileAccess.Write))
            {
                fs.Write(new byte[] { 0, 1, 2 }, 0, 3);
                fs.Close();
            }
            bool Before_1_File = File.Exists(Directory.GetCurrentDirectory() + "\\testrunner.c");
            bool Before_2_File = File.Exists(Directory.GetCurrentDirectory() + "\\a.exe");
            Assert.True(Before_1_File);
            Assert.True(Before_2_File);
            PrepareDirectoryClass.Prepare();
            bool After_1_File = File.Exists(Directory.GetCurrentDirectory() + "\\testrunner.c");
            bool After_2_File = File.Exists(Directory.GetCurrentDirectory() + "\\a.exe");
            Assert.False(After_1_File);
            Assert.False(After_2_File);
        }
    }
}
