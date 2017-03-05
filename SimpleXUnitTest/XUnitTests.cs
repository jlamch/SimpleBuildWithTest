using SimpleBuild;
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
    }
}
