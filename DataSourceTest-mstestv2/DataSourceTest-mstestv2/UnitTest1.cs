using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataSourceTest_mstestv2
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext
        {
            get; set;
        }

        [DeploymentItem("a.csv")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "a.csv", "a#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethod1()
        {
            var item1 = this.TestContext.DataRow["Item1"];
            var item2 = this.TestContext.DataRow["Item2"];
            var item3 = this.TestContext.DataRow[2];
        }
    }
}
