using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("Sec5Quiz")]
    public class Sec5Quiz
    {
        double celsius;
        double fahrent;

        [TestMethod]
        public void Convert_F_to_C()
        {
            //given the temperature in fahrenheit use a math expression
            // to convert the temperature to celsius.
            //display the output string to the console that says
            // "The temp in F {givenTemp} is {temp} in C"
            //replacing the values as necessary in the string
            // Formula ((F -32) *5)/9 = C
            
            //Arrange
            fahrent = 57;

            //Act
            double temp = (fahrent - 32) * 5 / 9;
            Console.WriteLine(temp);
            string output = String.Format("The temp in F {0} is {1} in C",fahrent, temp);
            Console.WriteLine(output);

            //Assert using a tolerance
            Assert.AreEqual(temp, 13.89, 0.01);

        }

        [TestMethod]
        public void Convert_C_to_F()
        {
            //given the temperature in fahrenheit use a math expression
            // to convert the temperature to celsius.
            //display the output string to the console that says
            // "The temp in C {givenTemp} is {temp} in F"
            //replacing the values as necessary in the string
            // Formula ((C x 9)/5) + 32 = F

            //Arrange
            celsius = 12.5;

            //Act
            double temp = (celsius * 9) / 5 + 32;
            Console.WriteLine(temp);
            string output = String.Format("The temp in C {0} is {1} in F", celsius, temp);
            Console.WriteLine(output);

            //Assert
            Assert.AreEqual(temp, 54.5, 0.01);

        }
    }
}
