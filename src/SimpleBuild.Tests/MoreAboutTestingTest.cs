// <copyright file="MoreAboutTestingTest.cs">Copyright ©  2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleBuild;

namespace SimpleBuild.Tests
{
    /// <summary>This class contains parameterized unit tests for MoreAboutTesting</summary>
    [PexClass(typeof(MoreAboutTesting))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MoreAboutTestingTest
    {
        /// <summary>Test stub for IsStringLong(String)</summary>
        [PexMethod]
        public bool IsStringLongTest([PexAssumeUnderTest]MoreAboutTesting target, string input)
        {
            bool result = target.IsStringLong(input);
            return result;
            // TODO: add assertions to method MoreAboutTestingTest.IsStringLongTest(MoreAboutTesting, String)
        }
    }
}
