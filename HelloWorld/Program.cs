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
    }
}
