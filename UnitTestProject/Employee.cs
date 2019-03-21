using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    class Employee
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfHire { get; set; }
		public string JobTitle { get; set; }
        public string Location { get; set; }
        public double Salary { get; set; }

		//Contructors
		public Employee(int id)
		{
			EmployeeId = id;
			DateOfHire = DateTime.Now;
		}

        public Employee(string firstName, string lastName, int id, string jobTitle)
        {
            
            FirstName = firstName;
            LastName = lastName;
            DateOfHire = DateTime.Now;
			EmployeeId = id;
			JobTitle = jobTitle;
            
        }

        public string GetFullName()
        {
            string result = String.Format("{0} {1}", FirstName, LastName);
            Console.WriteLine(result);

            return result;
        }

        public string GetFormattedName()
        {
            string result = String.Format("{0}, {1}", LastName, FirstName);
            Console.WriteLine(result);

            return result;
        }

        public void AddSalary(double _salary)
        {
            Salary = _salary;
        }

		public string GetLocation(string jobTitle)
		{
			string location;

			switch (jobTitle)
			{
				case "Manager":
					location = "Springfield";
					break;
				case "CSuite":
					location = "NYC";
					break;
				case "Engineer":
					location = "Denver";
					break;
				default:
					location = "Salt Lake City";
					break;
			}

			return location;
		}

		public void AddLocation(Employee employee)
		{
			employee.Location = employee.GetLocation(employee.JobTitle);
			Console.WriteLine(employee.JobTitle, employee.Location);
		}

		public void ChangeJobTitle(string jobTitle)
		{
			JobTitle = jobTitle;
		}


    }
}
