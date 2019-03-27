using System;

namespace UnitTestProject
{
	public enum JobTitle
	{
		Manager = 1,
		Engineer = 2,
		CodeMonkey = 3
	}

	public class Employee
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfHire { get; set; }
		public JobTitle JobTitle { get; set; }
        public string Location { get; set; }
        public double Salary { get; set; }

		//Contructors
		public Employee(int id)
		{
			EmployeeId = id;
			DateOfHire = DateTime.Now;
		}

        public Employee(string firstName, string lastName, int id, JobTitle jobTitle)
        {
			//Enum.GetName(typeof(JobTitle), jobTitle);
			//int x = (int)jobTitle;
			//JobTitle y = (JobTitle)x;
            
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

		public string GetLocation(JobTitle jobTitle)
		{
			string location;

			switch (jobTitle)
			{
				case JobTitle.Manager:
					location = "Springfield";
					break;
				case JobTitle.CodeMonkey:
					location = "NYC";
					break;
				case JobTitle.Engineer:
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
			Console.WriteLine(employee.JobTitle.ToString(), employee.Location);
		}

		public void ChangeJobTitle(JobTitle jobTitle)
		{
			JobTitle = jobTitle;
		}


    }
}
//Every Class inherits from the object class allowing us to use
//	Equals, Finalize, GetHashCode, ToString