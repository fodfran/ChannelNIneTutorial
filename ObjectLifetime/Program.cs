using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Honda", "Japan", 1992, "red");

            Car myOtherCar;
            myOtherCar = myCar; //references the same object
            Console.WriteLine(myOtherCar.Color); //red
            myOtherCar.Color = "blue";
            Console.WriteLine(myCar.Color);

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

    }
}