using System;

namespace MidTerm___Anthony_Musarra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1 :C++ has only three kinds of control structures, we refer to as control statements: the sequence statement, selection statements (three types—if, if...else and switch) and repetition statements (three types—while, for and do...while)

            //Question 2: 

            int i = 12;

            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 11)
                    keepLooping = false;
                i++;
                Console.WriteLine(i);
            }


            // Question 3:

            int j= 2;
            while (j<= 64)
            {
                {
                    if ((j % 2) == 0)
                    {
                        Console.WriteLine("[{0}]", j);
                    }
                    else if ((j % 2) != 0) 
                    {
                        Console.Write("");
                    }
                }   j*= 2;
            }

            // Question 4: 

            string a = ",";
            int b;
            for (b = 49; b >= 1; --b)
            {
                Console.Write(b);
                if (i>=2)
                {
                    Console.Write(a);
                }
            }



            // Question 5:

            int c = 1;
            while (c <=21)
            {
                {
                    if ((c % 2) ==0)
                    {
                        Console.Write(" ");
                    }
                    else if ((c %2)!= 0)
                    {
                        Console.Write(c);
                    }
                    c++;

                }

                // Question 6 the out put for the code is 
                // int n= 8
                //int i = 10;
                // while (i < n)
                // { console.write("*");
                    //i++
                    //}



                // Question 7: we combine multiple Boolean values by nested if or id else statements. Three primary operators that we can use are !, &&, and []?

                // Extra credit 


                

            }




















        }
    }
}
