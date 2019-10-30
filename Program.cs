using System;

namespace InClass_week2__Anthony_Musarra_
{
    class Program
    {
        static void Main(string[] args)
        {
            //int mynumber
            Car mymobile = new Car();

            mymobile.make = "Honda";
            mymobile.model = "Civic";
            mymobile.color = "blue";

            Console.WriteLine("Enter the year of your car: ");
            //mymobile.year = Console.ReadLine();
            mymobile.year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("My car is a {0} {1} {2} {3}",mymobile.year,mymobile.color,mymobile.make,mymobile.model);
        }
    }

}
