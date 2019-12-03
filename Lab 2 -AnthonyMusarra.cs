using System;

namespace Lab_2__Anthony_Musarra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}\n{1}", "Hello World", "from Anthony!");

            System.Console.Write("press any key to continue...");
            System.Console.ReadKey();

            int number1;
            int number2;
            int sum;

            Console.Write("Enter the first number:");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number:");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("the sum is {0}", sum);




            // Question 4: it executes at about the 18th line wherein it has the user enter in a variable.
            // 4b. int is mainly used for whole numbers while double is used more for binary decimals like 10.22.
            // 4c. public string GetName()
                // {
                //     return name;
                // }
            
            // Question 4d: get and set accessors
            // 4e: An object is an instance of a class and a class is the definition of an object.
        }
    }
}
