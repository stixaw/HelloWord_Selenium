using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class StringClassTests
    {
        [TestMethod]
        public void Using_String_Class()
        {
            //Arrange
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);

            //Act
            string substr = str.Substring(23);
            Console.WriteLine(substr);

            //Assert
            Assert.IsTrue(substr == "San Pedro");
        }

        [TestMethod]
        public void StringJoining_Successful()
        {
            //Arrange
            char[] chars = { 'H', 'e', 'l', 'l', 'o' };

            //Act
            string name = new string(chars);
            Console.WriteLine(name);

            //Assert
            Assert.IsTrue(name == "Hello");
        }
    }
}
