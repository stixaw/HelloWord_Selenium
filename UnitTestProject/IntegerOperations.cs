using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Section5")]
    public class IntegerOperations
    {
        int num1;
        int num2;

        [TestInitialize]
        public void RunBeforeEachTestMethod()
        {
            //set values for the unit tests
            num1 = 10;
            num2 = 5;
        }

        [TestMethod]
        public void Test_Addition()
        {
            //Arrange
            //TestInitialize

            //Act
            int result = num1 + num2;

            //Assert
            Assert.AreEqual(result, 15);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            //Arrange
            //TestInitialize

            //Act
            int result = num1 - num2;

            //Assert
            Assert.IsTrue(result == 5);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Test_Multiplication()
        {
            //Arrange
            //TestInitialize

            //Act
            int result = num1 * num2;

            //Assert
            Assert.AreNotEqual(result, 50);

        }

        [TestMethod]
        public void Test_Division()
        {
            //Arrange
            //TestInitialize

            //Act
            int result = num1 / num2;

            //Assert
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            //Arrange
            //TestInitialize

            //Act
            int result = num1 % num2;

            //Assert
            Assert.IsFalse(result == 1);

        }
    }
}
