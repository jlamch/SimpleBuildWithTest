using NUnit.Framework;
using SimpleBuild;

namespace NUnit2Test
{
    [TestFixture]
    public class NUnit2Tests
    {
        [Test]
        public void NUnit2TestMethod()
        {
            var expected = 2;
            var c = new SimpleClassToBeTested();

            var result = c.AddNumbers(1, 1);

            Assert.AreEqual(expected, result);
        }
    }
}
