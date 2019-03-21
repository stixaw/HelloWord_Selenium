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

		[TestMethod]
		public void Car_Accelerate_Success()
		{

			//Act
			var result = car1.Accelerate();


			//Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void Car_IsFamilyCar_True()
		{
			//Arrrange
			car1.AddCarDoors(5);

			//Act
			bool result = car1.IsFamilyCar();


			//Assert
			Assert.IsTrue(result == true);
		}

    }
}
