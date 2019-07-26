using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

namespace MSTestTests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext
        {
            get;
            set;
        }

        [TestMethod]
        public void CheckCurrentYear()
        {
            var day = new DateTime(DateTime.Now.Year, 1, 1);
            // Thread.Sleep(100 * 1000);
            Assert.IsTrue(HelloWorld.Common.YearUtils.IsCurrentYear(day));
        }

        [TestMethod]
        public void CheckLastYear()
        {
            int day = 1;
            var dayLastYear = new DateTime(DateTime.Now.Year - 1, 1, day);
            // Thread.Sleep(100 * 1000);
            Assert.IsTrue(HelloWorld.Common.YearUtils.IsLastYear(dayLastYear));
        }

        [TestMethod]
        public void TestThatFails()
        {
            this.Foo();
        }

        private void Foo()
        {
            this.Bar();
        }

        private void Bar()
        {
            throw new NotImplementedException();
        }


        [TestMethod]
        public void TestMethodTextContextWriteLine()
        {
            this.TestContext.WriteLine("Hello There");
        }

        [TestMethod]
        public void TestMethodLoggerLogMessage()
        {
            Logger.LogMessage("Hello from LogMessage");
        }

        [TestMethod]
        public void TestWithLongNameeeeeeeeeeeeeeeeeeeeeeeeeeeee()
        {
        }
    }
}
        