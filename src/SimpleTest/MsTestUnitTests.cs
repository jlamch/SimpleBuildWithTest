using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleBuild;
using System;

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

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MsTestTes_MoreAboutTesting_ShouldThrowException()
        {
            var arg = string.Empty;
            var c = new MoreAboutTesting();

            var result = c.IsStringLong(arg);

            //Assert.???;
        }

        [TestMethod]
        public void MsTestTes_MoreAboutTesting_ShouldThrowExceptionAssert()
        {
            // Arrange 
            var arg = string.Empty;
            var c = new MoreAboutTesting();
            Exception expectedExcetpion = null;

            // Act
            try
            {
                var result = c.IsStringLong(arg);
            }
            catch (Exception ex)
            {
                expectedExcetpion = ex;
            }

            // Assert
            Assert.IsNotNull(expectedExcetpion);
        }
    }
}
