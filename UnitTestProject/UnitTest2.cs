using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    [TestCategory("LeapYearTests")]
    public class UnitTest2
    {
        [TestMethod]
        public void LeapYear_2018_False()
        {
            //Arrange
            int year = 2018;

            //Act
            var result = IsItLeapYear(year);
            Console.WriteLine(result);

            //Assert
            Assert.IsTrue(result == false);
        }

        [TestMethod]
        public void LeapYear_2020_True()
        {
            //Arrange
            int year = 2020;

            //Act
            var result = IsItLeapYear(year);
            Console.WriteLine(result);

            //Assert
            Assert.IsTrue(result == true);
        }

        private static bool IsItLeapYear(int _year)
        {
            bool leap = false;
            int year = _year;

            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    leap = true;
                }
            }
            Console.WriteLine("Is the year {0} a leap year: {1}.", year, leap);
            return leap;
        }
    }
}
