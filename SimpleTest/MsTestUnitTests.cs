using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleBuild;

namespace SimpleTest
{
    [TestClass]
    public class MsTestUnitTests
    {
        [TestMethod]
        public void MsTestTestMethod()
        {
            var expected = 2;
            var c = new SimpleClassToBeTested();

            var result = c.AddNumbers(1, 1);

            Assert.AreEqual(expected, result);
        }
    }
}
