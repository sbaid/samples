using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataSourceItem
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DeploymentItem(@"XMLFile1.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"|DataDirectory|\XMLFile1.xml", "TestData", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethod1()
        {
            var myData = TestContext.DataRow["MyColumn"].ToString();
            Assert.IsTrue(myData.Contains("\r"), "XML data does not contain expected carriage-return character");
        }

    }
}
