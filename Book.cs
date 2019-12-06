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


        // Question 3: 






    }

        
        
       




    }
