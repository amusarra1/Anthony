using System;

namespace Lab6___Anthony_Musarra
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: [0], [1], [2], and [3]

            // Question 2:

            int[] array = new int[12];

            Console.WriteLine("{0}{1,15}", "index", "Month");
            {
                string[] month = new string[12];
                month[0] = "January";
                month[1] = "February";
                month[2] = "March";
                month[3] = "April";
                month[4] = "May";
                month[5] = "June";
                month[6] = "July";
                month[7] = "August";
                month[8] = "September";
                month[9] = "october";
                month[10] = "November";
                month[11] = "December";

                {
                    for (int counter = 0; counter < array.Length; ++counter) 

                    Console.WriteLine("{0}{1,15}", counter, string[month]);
                }

                // Question 3: 

                string[] seasons = { "winter", "spring", "summer", "autumn" };
                Console.WriteLine("The Four Seasons");
                foreach (string season in seasons)
                {
                    Console.WriteLine(season);
                }


                // Question 4: 

                int[] array;
                array = new int[1000];
                {
                    Random randomnumbers = new Random(1000);
                    int randomNumber = randomNumber.Next();
                    {
                        foreach (randomNumber in random.Next(0, 100)) ;
                        Console.WriteLine("{0}");
                    }
                }

                // Question 5: 

                {
                    string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
                    int i = 0;
                    {
                        while (i < names.Length)
                            Console.WriteLine(names[0]);
                    }





                }
            }


            // Question 6:


            string[] names = new string[5] { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            {
                for (int i = 0; i < names.Length; ++i) ;
                Console.WriteLine("{0,2}.{1}", i, names[i]);
            }


            // Question 7: 

            string[] names = new string[5] { "Al Dente", "Anna Graham", "Earl Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            {
                foreach (string name in names)
                    Console.WriteLine("{0,2}.{1}", i, names[i]);
            }






























































        }
    }
}
