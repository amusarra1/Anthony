using System;

namespace Lab_3_Anthony_Musarra
{
    class Program
    {
        private static int speed;
        private static bool i;

        public static int Speedlimit { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Question 1: One similarity between these two statements is that both of them work only if the given condition is true. Another similarity is that the syntax and structure of both statements is almost the same. A difference between the statements are that if single-selection statement can be guaranteed to run only one time or never. while repetition the looping statement might run many times.

            //Question 2: 
            if (speed> Speedlimit)
           Console.WriteLine("Slow down");
               else
           Console.WriteLine("Speed is acceptable");
           

            //Question 3: 
            {
                int istrue = 10;
                if (istrue <= 60)
                    Console.WriteLine("It is true");
                else
                    Console.WriteLine("It is false"); 

            }



            //Question 4:


        

           


            //Question 5

             for (int i = 1; i <= 10; i++) 

            {
                Console.WriteLine(i);
            }

            //Question 6
            for (int = 61 - 1; int >=20; int--)
            {
                Console.Write(i);

            }

              






        }

        private static void printTemp(int temperature)
        {
            
        }
    }

        
        
         
        }
   
