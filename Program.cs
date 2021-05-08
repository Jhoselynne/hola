using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areEqual = true;
            string message = "Bananer";
            string pappa = "Äpplen";

            if (areEqual)
            {
                Console.WriteLine("areEqual innehåller " + areEqual);
                Console.WriteLine("message innehåller " + message);
                Console.WriteLine("10 = 9 är " + (10 == 9));
                // Console.WriteLine("The current time is " + DateTime.Now);
            }
            else
            {
                Console.WriteLine(pappa);                
            }

        }
    }
}
