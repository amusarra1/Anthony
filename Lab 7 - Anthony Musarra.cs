using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7___Anthony_Musarra
{
       class Book
    {

        private string Title;
        private string Author;
        private int Year;
       
        public Book(string Title, string Author, int Year)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
        }
        public Book(string Title, int Rating, string Director)
        {
            this.Title = Title;
            this.Author = Director;
          
        }

        public Book(string Title)
        {
            this.Title = Title;
        }
        public void Display()
        {
            Console.WriteLine("{0} directed by {1} released in {2}\n", Title, Author, Year);
        }


        // Question 3: create an instance of that calss with thte 'new' keyword in main activity and then invoke those methods on that object.
        // Question 4: A new logic can be added to the existing constructor method of class, or two new constructor methods can be created for class.
        // A new constructor method is created which, in response to obtaining the stored information of the class's initial location.
        // Question 5: Exception handling is used to prevent application from being stuck due to unusual occurrences. If the exceptions are handled properly, the application will never get terminated.
        // Question 6:The public keyword specifies that a variable or function is available to any caller. Because variables and functions are public by default, this keyword is used primarily for stylistic and readability benefits, indicating that the variable exists in the current scope. For example, you might want to use this keyword for consistency in a block of code that also contains private or static variables. This keyword can be used with either the public or private keyword
        // Question 7: Composition is the design technique to implement has-a relationship in classes.
        //     class Book {

       // private Book book;

      //  Book(Book bookSpecification)
      //  {
      //      Book = new Book(bookSpecification);
      //  }
        

        // Question 8: Data abstraction is the reduction of a particular body of data to a simplified representation of the whole. Abstraction, in general, is the process of taking away or removing characteristics from something in order to reduce it to a set of essential characteristics.








    }








}
