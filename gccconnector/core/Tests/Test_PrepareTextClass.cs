using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace CatUnitStudio
{
    public class Test_PrepareTextClass
    {
        [Fact]
        public void Test_PrepareTextClass_PrepareText()
        {
            string TmpString = "\nABC\tABC\r";
            string result = PrepareTextClass.PrepareText(TmpString);
            Assert.Equal("ABCABC", result);
        }
    }
}
