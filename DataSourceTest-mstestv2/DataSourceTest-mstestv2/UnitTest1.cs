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
        public void TestWithCsvData()
        {
            var item1 = this.TestContext.DataRow["Item1"];
            var item2 = this.TestContext.DataRow["Item2"];
            var item3 = this.TestContext.DataRow[2];
        }

        [DeploymentItem("data.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "data.xml", "Row", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestWithXmlData()
        {
            var value1 = Convert.ToInt32(this.TestContext.DataRow["Value1"]);
            var value2 = Convert.ToInt32(this.TestContext.DataRow["Value2"]);
            var expectedValue = Convert.ToInt32(this.TestContext.DataRow["ExpectedValue"]);
            Assert.AreEqual(value1 + value2, expectedValue);
        }
    }
}
