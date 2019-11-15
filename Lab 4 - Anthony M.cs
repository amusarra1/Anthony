using System;

namespace Lab4__Anthony_Musarra
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: initialize control variable, display counter value, increment the control variable, repeat.
            // Question 2: for is an entry loop. The loop continuation condition is checked at the time of entering the loop. while is an entry control loop. The continuation condition is checked at the time of entering the loop.
            // Question 3: do-while evaluates its expression at the botom of the loop, and therefore, the statements within the do block are always executed at least once. by using do-while you may gain performance if the expression/condition is complex.
            // Question 4: odd/even

            int i;

            for (i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }

            //Question 5:

            {
                Console.Write("Please enter a temperature: ");

                int temp = Convert.ToInt32(Console.ReadLine());

                if (temp >= 90) { Console.WriteLine("fish"); }

                else if (temp >= 80) { Console.WriteLine("Lion"); }

                else if (temp >= 70) { Console.WriteLine("Turle"); }

                else if (temp >= 60) { Console.WriteLine("Deer"); }

                else if (temp >= 50) { Console.WriteLine("Reindeer"); }

                else if (temp >= 40) { Console.WriteLine("Moose"); }

                else if (temp >= 20) { Console.WriteLine("Penguin"); }

                else if (temp >= 10) { Console.WriteLine("Polar Bear"); }

                else { Console.WriteLine("Bug"); }


                //Question 6:

                {
                    Console.Write("Please enter the exhibit number: ");

                    int exhibit = Convert.ToInt32(Console.ReadLine());

                    if (exhibit >= 9) { Console.WriteLine("bug"); }

                    else if (exhibit >= 8) { Console.WriteLine("fish"); }

                    else if (exhibit >= 7) { Console.WriteLine("lion"); }

                    else if (exhibit >= 6) { Console.WriteLine("turtle"); }

                    else if (exhibit >= 5) { Console.WriteLine("deer"); }

                    else if (exhibit >= 4) { Console.WriteLine("reindeer"); }

                    else if (exhibit >= 3) { Console.WriteLine("moose"); }

                    else if (exhibit >= 2) { Console.WriteLine("penguin"); }

                    else if (exhibit >= 1) { Console.WriteLine("Polar bear"); }



                    //Question 7: add console.writline ("*******"); to make each number have its own line. int i in this case is already in use so it is struggling to run this specific program.

                        

                    
                      //  int i = 10;
                       // while (i < 21)
                        {
                          //  Console.WriteLine(i);
                           // Console.Writeline("*******");
                        }

                    
                    // Question 8: the only problem with this code is that it could be spaced out more. If you use the code given it will do 0-100 with *** under each number.


                    // Extra: 


                }




            }











        }  
        
                
                


        
        
                    

                    
                    
                      
       
    
    }
    
}


