using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class IfStatements
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
        public void num1_Equal_Num2()
        {
            //Act
            bool result = num1 == num2;
            Console.WriteLine(result);

            //Assert
            Assert.IsTrue(result == false);
        }

        [TestMethod]
        public void Num1_NotEqual_Num2()
        {

            //Act
            bool result = num1 != num2;
            Console.WriteLine(result);

            //Assert
            Assert.IsTrue(result == true);
        }
    }
}
