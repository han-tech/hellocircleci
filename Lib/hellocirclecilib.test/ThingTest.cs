using hellocirclelib;
using System;
using Xunit;

namespace hellocirclecilib.test
{
    public class ThingTest
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("42", new Thing().Get(19, 23));
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal("41", new Thing().Get(19, 24));
        }
    }
}
