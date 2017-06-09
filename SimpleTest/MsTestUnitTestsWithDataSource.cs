using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestHacks;
using SimpleBuild;
using System.Collections.Generic;

namespace SimpleTest
{
    [TestClass]
    public class MsTestUnitTestsWithDataSource : MSTestHacks.TestBase
    {

        [TestMethod]
        [DataSource("SimpleTest.MsTestUnitTestsWithDataSource.CasesNegative")]
        public void MsTes_MoreAboutTesting_FromDataSource()
        {
            var c = new MoreAboutTesting();
            var arg = TestContext.GetRuntimeDataSourceObject<string>();

            var result = c.IsStringLong(arg);

            Assert.IsFalse(result);
        }

        private IEnumerable<string> CasesNegative
        {
            get
            {
                return new List<string> { "abc", "adgh" };
            }
        }
    }
}
