using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatUnitStudio
{
    public class TestResultClass
    {
        public string TestName { get; set; }        // Имя теста
        public string Message { get; set; }         // Сообщение
        public bool Result { get; set; }            // Результат

        public TestResultClass(string TestName, string Message, bool Result)
        {
            this.TestName = TestName;
            this.Message = Message;
            this.Result = Result;
        }
    }
}
