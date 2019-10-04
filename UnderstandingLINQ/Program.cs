using System;
using System.Collections.Generic;
using System.Linq;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make = "BMW", Model = "550i", StickerPrice=55000, Year= 2009},
                new Car() { VIN = "B2", Make = "Toyota", Model = "4Runner", StickerPrice=35000, Year= 2010},
                new Car() { VIN = "C3", Make = "BMW", Model = "745li", StickerPrice=75000, Year= 2008},
                new Car() { VIN = "D4", Make = "Ford", Model = "Escape", StickerPrice=25000, Year= 2008},
                new Car() { VIN = "E5", Make = "BMW", Model = "55i", StickerPrice=57000, Year= 2010}
            };

            //LINQ query
            
            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model };
            
            /*var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car
            */

            //LINQ method
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            var orderedCars = myCars.OrderByDescending(p => p.Year); //A1
            var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW"); //E5

            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012)); //False, 2009 also false

            myCars.ForEach(p => p.StickerPrice -= 3000); 
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            Console.WriteLine(myCars.Exists(p => p.Model == "745li")); //True
            Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            Console.WriteLine(myCars.GetType()); //System.Collections.Generic.List`1[UnderstandingLINQ.Car]
            Console.WriteLine(orderedCars.GetType()); //System.Linq.OrderedEnumerable`2[UnderstandingLINQ.Car,System.Int32]
            Console.WriteLine(bmws.GetType()); //System.Linq.Enumerable+WhereListIterator`1[UnderstandingLINQ.Car]

            Console.WriteLine(newCars.GetType()); //System.Linq.Enumerable+WhereSelectListIterator`2[UnderstandingLINQ.Car,<>f__AnonymousType0`2[System.String,System.String]]
            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.Model, car.VIN);
            }
            */

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
