using System.Collections.Generic;
using freamWorkValidation.Reflector.RelectiationClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using freamWorkValidation.BaseClass;
using freamWorkValidation.validation;

namespace ValidationFrameworkTestProject
{
    
    
    /// <summary>
    ///This is a test class for ReflcationClassPropertyTest and is intended
    ///to contain all ReflcationClassPropertyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ReflcationClassPropertyTest
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


        /// <summary>
        ///A test for ReflectionAttribute
        ///</summary>
        [TestMethod()]
        public void ReflectionAttributeTest()
        {
            Type type = null; // TODO: Initialize to an appropriate value
            string propertyName = string.Empty; // TODO: Initialize to an appropriate value
            Validator expected = null; // TODO: Initialize to an appropriate value
            Validator actual;
            actual = ReflcationClassProperty.GetValidator(type, propertyName);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetValidator
        ///</summary>
        [TestMethod()]
        public void GetValidatorTest()
        {
            Type type = typeof(Person);
            string propertyName = "Name"; // TODO: Initialize to an appropriate value
            Validator expected = new AndCompositeValidator(new NotNullValidator()); // TODO: Initialize to an appropriate value
            Validator actual;
            actual = ReflcationClassProperty.GetValidator(type, propertyName);
            Assert.IsTrue(actual is AndCompositeValidator);
            var actualValidator = actual as AndCompositeValidator;
            var children = new List<Validator>(actualValidator.ListValidator);
            Assert.IsTrue(children.Count == 1);
            Assert.IsTrue(children[0] is NotNullValidator);
        }
    }
}
