using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("FloatingPoint")]
    public class FloatingPoint
    {
        double num1;
        double num2;

        [TestInitialize]
        public void RunBeforeEachTestMethod()
        {
            //set values for the unit tests
            num1 = 10.5;
            num2 = 5.0;
        }

        [TestMethod]
        public void Float_Addition()
        {
            //Act
            double result = num1 + num2;

            //Assert
            Assert.AreEqual(result, 15.5);

        }

        [TestMethod]
        public void Float_Subtraction()
        {

            //Act
            double result = num1 - num2;

            //Assert
            Assert.IsTrue(result == 5.5);

        }

        [TestMethod]
        public void Float_Multiplication()
        {

            //Act
            double result = num1 * num2;
            Console.WriteLine(result);

            //Assert
            Assert.AreEqual(result, 52.5);

        }

        [TestMethod]
        public void Float_Division()
        {

            //Act  division just lops them off the end (truncate instead of round)
            double result = num1 / num2;
            Console.WriteLine(result);

            //Assert
            Assert.AreEqual(result, 2.1);

        }

        [TestMethod]
        public void Float_Modulus()
        {

            //Act
            double result = num1 % num2;
            Console.WriteLine(result);

            //Assert
            Assert.AreEqual(result, 0.5);

        }
    }
}
