using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Quiz
    {
        //1. All tests should have the category as Quiz
        //2. 3 test methods
        //3. One test checks that 1 + 1 = 2.
        //4. One Test automatically fails
        //5. One test that checks taht 10 + 10 = 21 and expects to fail.


        [TestMethod]
        public void AddIntegers_AreEqual()
        {
            //Arrange
            int a = 1;
            int b = 1;

            //Act
            int result = a + b;

            //Assert
            Assert.AreEqual(result, 2);
        }

        //[TestMethod]
        //public void Test_AutoFail()
        //{
        //    //Arrange


        //    //Act


        //    //Assert
        //    Assert.Fail("This is a failure");
        //}

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AddIntegers_ExpectsToFail()
        {
            //Arrange
            int a = 10;
            int b = 10;

            //Act
            int result = a + b;

            //Assert
            Assert.AreEqual(result, 21);
        }
    }
}
