using System;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString()); //9/29/2019 6:29:11 PM
            Console.WriteLine(myValue.ToShortDateString()); //9/29/2019
            Console.WriteLine(myValue.ToShortTimeString()); //6:30 PM
            Console.WriteLine(myValue.ToLongDateString()); //Sunday, September 29, 2019
            Console.WriteLine(myValue.ToLongTimeString()); //6:32:39 PM

            Console.WriteLine(myValue.AddDays(3).ToLongDateString()); //Wednesday, October 2, 2019
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString()); //9:37:45 PM
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString()); //Thursday, September 26, 2019

            Console.WriteLine(myValue.Month); //9

            DateTime myBirthday = new DateTime(1992, 5, 15);
            Console.WriteLine(myBirthday.ToShortDateString()); //5/15/1992

            DateTime myBirthday2 = DateTime.Parse("5/15/1992");

            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays); //9998.78460374279



            Console.ReadLine();
        }
    }
}
