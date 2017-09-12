using System;
using NUnit.Framework;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestFixture]
    public class Class1

    {
        [Test]
        public void ProcessNameTest()

        {
            Assert.AreEqual("vstest.executionengine.x86.clr20", Process.GetCurrentProcess().ProcessName);
        }

        [Test]
        public void ImageRuntimeVersionTest()
        {
            Assert.AreEqual("v2.0.50727", typeof(object).Assembly.ImageRuntimeVersion);
        }
    }
}
