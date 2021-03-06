﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class EmployeeTests
    {
		Employee emp1;

		[TestInitialize]
		public void SetUp()
		{
			Employee emp1 = new Employee("John", "Smoth", 2, (JobTitle)2);
			if (emp1.JobTitle != JobTitle.Manager)
			{
				Console.WriteLine("I am an employee");
			}
		}

        [TestMethod]
        public void Employee_GetName_Successful()
        {
            //Act
            string result = emp1.GetFullName();

            //Assert
            Assert.AreEqual("John Smoth", result);
        }

        [TestMethod]
        public void Employee_GetFormattedName_Successful()
        {

            //Act
            string result = emp1.GetFormattedName();

            //Assert
            Assert.AreEqual("Smoth, John", result);

        }

        [TestMethod]
        public void Employee_GetEmployeeNumber_Match()
        {

            //Act
            int result = emp1.EmployeeId;
            Console.WriteLine(result);

            //Assert
            Assert.AreEqual(result, 2);
        }

		[TestMethod]
		public void Employee_GetDateOfHire_NotNull()
		{

			//Act
			var result = emp1.DateOfHire;
			Console.WriteLine(result);


			//Assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void Employee_LocationMatchesJobTitle_Success()
		{

			//Act
			var location = emp1.GetLocation(emp1.JobTitle);
			Console.WriteLine(location);

			//Assert
			Assert.AreEqual(location, "Springfield");
		}

		[TestMethod]
		public void Employee_LocationChangesWithJobChange_Success()
		{
			//Arrange
			emp1.ChangeJobTitle("Engineer");

			//Act
			var location = emp1.GetLocation(emp1.JobTitle);
			Console.WriteLine(location);

			//Assert
			Assert.AreNotEqual(location, "Springfield");
		}
    }
}
