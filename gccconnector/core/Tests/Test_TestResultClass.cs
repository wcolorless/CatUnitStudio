using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CatUnitStudio
{
    public class Test_TestResultClass
    {

        [Fact]
        public void Test_TestResultClassCreate()
        {
            TestResultClass testResultClass = new TestResultClass("TestName", "TestMessage", true);
            Assert.Equal("TestName", testResultClass.TestName);
            Assert.Equal("TestMessage", testResultClass.Message);
            Assert.True(testResultClass.Result == true);
        }
    }
}
