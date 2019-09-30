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
            Console.WriteLine(myCar.Color); //now it's blue

            Car.MyMethod();

            //myOtherCar = null; //remove one reference
            //myCar = null; //removed all references. object will be removed in some unknown time

            Console.ReadLine();

        }
    }

    class Car
    {
        public static string Make { get; set; }
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

        public static void MyMethod()
        {
            Console.WriteLine("Called static MyMethod");
            Console.WriteLine(Make);
        }
    }
}