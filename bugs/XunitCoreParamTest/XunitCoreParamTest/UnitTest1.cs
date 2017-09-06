using System;
using Xunit;

namespace XunitCoreParamTest
{
    public class Class1
    {
        [InlineData("hi", 1, 2, 3)]
        [Theory]
        public void Test1(params int[] args)
        {
        }
    }
}
