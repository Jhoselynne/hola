using System;

namespace myApp
{
    class Person
    {
        public string namn;
        public int year = 0;

        public Person(string namn)
        {
            this.namn = namn;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool areEqual = true;
            string message = "Bananer";
            string pappa = "Äpplen";

            Person person1 = new Person("Christian");

            if (areEqual)
            {
                Console.WriteLine("areEqual innehåller " + areEqual);
                Console.WriteLine("message innehåller " + message);
                Console.WriteLine("10 = 9 är " + (10 == 9));
                Console.WriteLine("person1.namn: " + person1.namn);
                Console.WriteLine("person1.year: " + person1.year);
                // Console.WriteLine("The current time is " + DateTime.Now);
            }
            else
            {
                Console.WriteLine(pappa);
            }

        }
    }
}
