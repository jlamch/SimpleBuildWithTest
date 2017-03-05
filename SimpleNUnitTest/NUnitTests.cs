using NUnit.Framework;
using SimpleBuild;

namespace SimpleNUnitTest
{
    [TestFixture]
    public class NUnitTests
    {
        [Test]
        public void NUnitTestMethod()
        {
            var expected = 2;
            var c = new SimpleClassToBeTested();

            var result = c.AddNumbers(1, 1);

            Assert.AreEqual(expected, result);
        }
    }
}