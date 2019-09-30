using System;
using System.Text;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life"; //My "so-called" life
            //string myString = "What if I need a\nnew line?"; //What if I need a
            //new line?
            //string myString = "Go to your c:\\ drive"; //Go to your c:\ drive
            //string myString = @"Go to your c:\ drive"; //Go to your c:\ drive

            //string myString = String.Format("{0} = {1}", "first", "second"); //first = second

            //string myString = String.Format("{0:C}",123.45); //$123.45
            //string myString = String.Format("{0:N}", 1234567890); //1,234,567,890.000
            //string myString = String.Format("{0:P}",.123); //12.300%
            //string myString = String.Format("{0:(###) ###-####}",1234567890); //(123) 456-7890

            //string myString = "  That summer we took threes across the board  "; //

            //myString = myString.Substring(6,14); // summer we too 
            //myString = myString.ToUpper(); //  THAT SUMMER WE TOOK THREES ACROSS THE BOARD  
            //myString = myString.Replace(" ", "--"); //----That--summer--we--took--threes--across--the--board----
            //myString = myString.Remove(6, 14); //  Thatk threes across the board  

            //myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length); //Length before: 47 -- Length after: 43

            /*string myString = ""; 
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString(); //--0--1--2--3--4--5--6--7--8--9--10...
            }*/

            /*StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i); ////--0--1--2--3--4--5--6--7--8--9--10...
            }*/
           
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
