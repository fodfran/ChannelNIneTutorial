using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Japanese";
            myCar.Year = 1992;
            myCar.Color = "red";

            decimal value = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", value);


            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            return carValue;
        }

        

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
            {
                carValue = 10000;
            }
            else
            {
                carValue = 2000;
            }
            return carValue;
        }

    }
}
