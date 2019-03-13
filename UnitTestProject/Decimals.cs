using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Decimals")]
    public class Decimals
    {
        decimal num1;
        decimal num2;
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
            num1 = 10.5M;
            num2 = 5.0M;
        }

        [TestMethod]
        public void Decimal_Addition()
        {
            //Act
            decimal result = num1 + num2;
            Console.WriteLine(result);

            //Assert
            Assert.IsTrue(result == 15.5M);
        }

        [TestMethod]
        public void Decimal_Substration()
        {

            //Act
            decimal result = num1 - num2;
            Console.WriteLine(result);

            //Assert
            Assert.AreEqual(result, 5.5M);
        }

        [TestMethod]
        public void Decimal_Multiplication()
        {

            //Act
            decimal result = num1 * num2;
            Console.WriteLine(result);

            //Assert
            Assert.AreEqual(result, 52.50M);

        }

        [TestMethod]
        public void Decimal_Division()
        {

            //Act
            decimal result = num1 / num2;
            Console.WriteLine(result);

            //Assert
            Assert.IsTrue(result == 2.1M);
        }

        [TestMethod]
        public void Decimal_Modulus()
        {

            //Act
            decimal result = num1 % num2;
            Console.WriteLine(result);

            //Assert
            Assert.AreEqual(result, 0.5M);
        }
    }
}
