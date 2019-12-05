using System;

namespace Lab_5___Anthony_Musarra
{
    class Program
    {
        

         // Question 1: Scope - double height, double width. Anything within () in a method header.
            // static v. non-static - if static you can access information all across the code. if not static then must fetch information some other way.
            // Return Type - Double in this example. signifies how the program returns information. can be void, or int aswell.
            // Method name - getarea in this example, tells the code where to go for information.
            // Parameters - public in this example, tells the code to access restrictions if any. Public don't have restrictions private do.
            // Method body - return height times width, Marks area of the code that must be executed.

            // Question 2:  User defined method is written by the user and are hidden from other methods. Methods provided by the framework are able to be reused from different locations in the code. when creating user-defined methods we should take into consideration to not reinvent the wheel.

            // Question 3: The difference between a static and non-static method is that a non static method is allowed to access all the nonstatic fields in an object. the static method does not have access to any of the objects non-static fields.

            // Question 4/5:

       public string bark;
       public static int name;
       public static int trickname;
        
        public static void Bark()
        {
            Console.WriteLine("{0} is Barking...", name);
            Console.WriteLine("{0} is so smart!  {0} is doing an {1}", name, trickname);
        }
    } 
                    
}
           

