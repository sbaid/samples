using System;
using Xunit;

namespace XUnitSample
{
    public class UnitTest1
    {
        [Fact]
        public void ThisTestAlwaysFails()
        {
            Assert.False(true);
        }

        [Fact]
        public void TestMethod2()
        {
        }

        [Fact]
        public void TestMethod3()
        {

        }
    }
}
