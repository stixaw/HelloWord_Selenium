using System;

namespace UnitTestProject
{
	class Car
    {
        // private variables
        int numberOfDoors;

        //Gets and Sets Accessors (define access to our variables)
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public decimal Cost { get; set; }
        public string OwnerName { get; set; }

        public int NumberOfDoors
        {
            get { return numberOfDoors; }
            set
            {
                if (value <= 5)
                {
                    numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("You done blew it");
                }
            }
        }

        //Constructor - factory that builds our objects
        public Car(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color.ToLower();

        }

        //Methods actions that the object can take
        public void AddCarDoors(int doors)
        {
            NumberOfDoors = doors;
        }

        public void AddCarCost(decimal cost)
        {
            Cost = cost;
        }

        public void AddOwnerName(string _owner)
        {
            OwnerName = _owner;
        }

        public void ChangeColor(string _color)
        {
            Color = _color.ToLower();
        }

        public string Accelerate()
        {
           string result = "I am speeding!!!";
			return result;
        }

        public bool IsFamilyCar()
        {
            if(NumberOfDoors >= 4)
            {
                return true;
            }
            else { return false; }
            
        }
    }
}
