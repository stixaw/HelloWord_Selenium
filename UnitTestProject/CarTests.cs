using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class CarTests
    {
        Car car1 = new Car("Mazda", "Rx3", "Red");

        [TestMethod]
        public void Car_ChangeColor_Successful()
        {

            //Act
            car1.ChangeColor("blue");
            Console.WriteLine(car1.Color);

            //Assert
            Assert.AreEqual(car1.Color, "blue");

        }

        [TestMethod]
        public void Car_AddCarDoors_Successful()
        {

            //Act
            car1.AddCarDoors(4);

            //Assert
            Assert.AreEqual(car1.NumberOfDoors, 4);
        }

    }
}
