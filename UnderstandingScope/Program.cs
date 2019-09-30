using System;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l); //error, l is out of scope
            }

            //Console.WriteLine(i); //error, i is out of scope
            Console.WriteLine(j); //outside the for: 9
            Console.WriteLine(k); //also 9

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething(); // helperMethod not accessible because private

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine(k); //k from the helpermethod: 9
        }

    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello world!";
        }
    }
}
