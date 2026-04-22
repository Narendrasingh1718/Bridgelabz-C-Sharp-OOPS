using System;
using System.Collections.Generic;
using System.Text;

namespace oops_program
{
    internal class Book
    {
        String title;
        String author;
        static double price;
        static Book()
        {
            price = 9.99;
        }
        public Book(String title, String author)
        {
            this.title = title;
            this.author = author;
        }
        public void display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }
}
