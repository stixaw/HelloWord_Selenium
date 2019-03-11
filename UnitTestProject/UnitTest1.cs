using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Notes")]
    public class AdditionUnitTests
    {
        public int a;
        public int b;
        public TestContext TestAdditionContext { get; set; }
        private static TestContext _testContext;

        [ClassInitialize]
        public static void RunBeforeAllTestMethodsInClass(TestContext testContext)
        {
            _testContext = testContext;
            Console.WriteLine("ClassInitialize");

        }

        [TestInitialize]
        public void RunBeforeEachTestMethod()
        {
            a = 1;
            b = 2;
        }

        [TestMethod]
        public void AddTwoIntegers_ResultAreEqual()
        {

            ////Arrange
            //int a = 1;
            //int b = 2;

            //Act
            int result = a + b;

            //Assert
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void AddTwoIntegers_ResultsAreNotEqual()
        {
            ////Arrange
            //int a = 1;
            //int b = 2;

            //Act
            int result = a + b;


            //Assert
            Assert.AreNotEqual(result, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void ExpectToFail()
        {
            ////Arrange
            //int a = 1;
            //int b = 2;

            //Act
            int result = a + b;

            //Assert
            Assert.IsFalse(result == 3);
        }

        [TestCleanup]
        public void RunAfterEachTestMethod()
        {
            Console.WriteLine("TestCleanup Ran");
        }
    }
}
