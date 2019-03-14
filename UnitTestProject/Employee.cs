using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    class Employee
    {
        public int EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfHire { get; set; }
        public string JobDescription { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        int employeeNum = 0;

        public Employee(string firstName, string lastName)
        {
            
            FirstName = firstName;
            LastName = lastName;
            DateOfHire = DateTime.Now;
            EmployeeNumber = employeeNum += 1;

            
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

        public void AddJobDescription(string jobDescription)
        {
            JobDescription = jobDescription;
        }

        public void AddSalary(double _salary)
        {
            Salary = _salary;
        }

        public void AddDepartment(string department)
        {
            Department = department;
        }
    }
}
