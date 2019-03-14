using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    class Car
    {
        // private variables
        int numberOfDoors;

        //Constructor - factory that builds our objects

        //Gets and Sets Accessors (define access to our variables)
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if (value <= 4)
                {
                    numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("You done blew it");
                }
            }
        }

        //Methods actions that the object can take

    }
}
