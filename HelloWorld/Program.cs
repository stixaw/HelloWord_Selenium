using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //HelloWorld();
            //stringInterpol();
            //Equality();
            //Relational();
            //IfStatement();
            //IfElseStatment();
            IsItLeapYear();

        }

        private static void IsItLeapYear()
        {
            bool leap = false;
            Console.WriteLine("Enter a year to determine if it is a leap year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    leap = true;
                }
            }

            Console.WriteLine("Is the year {0} a leap year: {1}.", year, leap);

        }

        private static void IfElseStatment()
        {
            int num1 = 22;
            int num2 = 3 * 4;

            if (num1 >= num2)
            {
                Console.WriteLine("{0} >= {1} = {2}", num1, num2, true);
            }
            else if (num1 <= num2)
            {
                Console.WriteLine("{0} <= {1} = {2}", num1, num2, true);
            }
            else
            {
                Console.WriteLine("We don't know");
            }
        }

        private static void IfStatement()
        {
            int num1 = 18;
            int num2 = 4;

            if (num1 == num2)
            {
                Console.WriteLine("{0} == {1} = {2}", num1, num2, true);
            }
            Console.WriteLine(false);
        }

        public static void HelloWorld()
        {
            Console.WriteLine("What is your Name? ");
            var username = Console.ReadLine();
            Console.WriteLine("Hello {0}", username);
            Console.ReadKey();
        }

        public static void stringInterpol()
        {
            //string interpolation
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you");
            int age = Convert.ToInt32(Console.ReadLine());

            var response = $"Your name is {name} and you are {age} years old";
            Console.WriteLine(response);
            Console.ReadKey();
        }

        public static void Equality()
        {
            //equality operators return booleans
            Console.WriteLine(1 == 1.0); //true
            Console.WriteLine(2 != 2.1); //true
        }

        public static void Relational()
        {
           //relational return bool
            Console.WriteLine(1 > 0); //true
            Console.WriteLine(2 < 3); //true
            Console.WriteLine(3 >= 2);//true
            Console.WriteLine(4 <= 5);//true
            Console.WriteLine(4 >= 5); //false
            Console.WriteLine(3 <= 2); //false
            // is type compatibility
            // as type conversion
            // && And
            Console.WriteLine(1 < 0 || -2 > 0);
            Console.WriteLine(1 != 0 && 2 > 0);
            // || OR
        }

    }
}
