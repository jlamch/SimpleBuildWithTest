using NUnit.Framework;
using SimpleBuild;
using System;

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


        [Test]
        public void NUnitTest_MoreAboutTesting_ShouldThrowException()
        {
            var arg = string.Empty;
            var c = new MoreAboutTesting();

            var act = new TestDelegate(() => c.IsStringLong(arg));

            Assert.Throws<ArgumentOutOfRangeException>(act);
        }

        [Test]
        [TestCase("abc", ExpectedResult = false, TestName = "ShortCase")]
        [TestCase("abcdefg", ExpectedResult = true, TestName = "LongCase")]
        public bool NUnitTest_MoreAboutTesting_TestCases(string arg)
        {
            var c = new MoreAboutTesting();

            var result = c.IsStringLong(arg);

            return result;
        }        
    }
}