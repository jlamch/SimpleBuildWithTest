using SimpleBuild;
using System;
using Xunit;

namespace SimpleXUnitTest
{
    public class XUnitTests
    {
        [Fact]
        public void XUnitTestMethod()
        {
            var expected = 2;
            var c = new SimpleClassToBeTested();

            var result = c.AddNumbers(1, 1);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void XUnitTest_MoreAboutTesting_ShouldThrowException()
        {
            var arg = string.Empty;
            var c = new MoreAboutTesting();

            var act = new Action(() => c.IsStringLong(arg));

            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

        
        [Theory]
        [InlineData("abc")]
        [InlineData("abcd")]
        public void XUnitTest_MoreAboutTesting_TheoriesNegative(string arg)
        {
            var c = new MoreAboutTesting();

            var result = c.IsStringLong(arg);

            Assert.False(result);
        }
         
        [Theory]
        [InlineData("abc12345")]
        [InlineData("abcd45")]
        public void XUnitTest_MoreAboutTesting_TheoriesPositive(string arg)
        {
            var c = new MoreAboutTesting();

            var result = c.IsStringLong(arg);
            
            Assert.True(result);
        }
    }
}
