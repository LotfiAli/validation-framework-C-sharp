using freamWorkValidation.BaseClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using freamWorkValidation.validation;
using freamWorkValidation.validationHelp;

namespace ValidationFrameworkTestProject
{
    
    
    /// <summary>
    ///This is a test class for ValidatorTest and is intended
    ///to contain all ValidatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ValidatorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual Validator CreateValidator()
        {
            // TODO: Instantiate an appropriate concrete class.
            Validator target = null;
            return target;
        }

        /// <summary>
        ///A test for isValid
        ///</summary>
        [TestMethod()]
        public void ContainStringValidationTest()
        {
            ////Validator target = CreateValidator(); // TODO: Initialize to an appropriate value
            ////object objectToValidate = null; // TODO: Initialize to an appropriate value
            ////bool expected = false; // TODO: Initialize to an appropriate value
            ////bool actual;
            ////actual = target.isValid(objectToValidate);
            ////Assert.AreEqual(expected, actual);
            ////Assert.Inconclusive("Verify the correctness of this test method.");

            //string word = "ali";
            //string continueString = "ali";

            //continueString<string> test = new continueString<string>(continueString, SerachText.Equal, "ali", "aa", "aaa");
            //Assert.IsTrue(test.isValid(word));
        }
        [TestMethod()]
        public void ContainStringValidationTest1()
        {
            ////Validator target = CreateValidator(); // TODO: Initialize to an appropriate value
            ////object objectToValidate = null; // TODO: Initialize to an appropriate value
            ////bool expected = false; // TODO: Initialize to an appropriate value
            ////bool actual;
            ////actual = target.isValid(objectToValidate);
            ////Assert.AreEqual(expected, actual);
            ////Assert.Inconclusive("Verify the correctness of this test method.");

            //string word = "ali";
            //string continueString = "ali";

            //continueString<string> test = new continueString<string>(continueString, SerachText.Equal, "ali", "aa", "aaa");
            //Assert.IsTrue(test.isValid(word));
        }
    }
}
