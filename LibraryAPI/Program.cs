using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book();
            //book.Title = "Intro to C#";
            //book.ISBN = 1234567;
            //book.Price = 12.34M;
            //book.Count = 5;
            //book.PublishedYear = new DateTime(2010, 1, 1);    //"1/1/2010"

            //Library.AddBook(book);

            //book = new Book();
            //book.Title = "Intro to Python";
            //book.ISBN = 1231212;
            //book.Price = 22.50M;
            //book.Count = 2;
            //book.PublishedYear = new DateTime(2012, 2, 1);

            //Library.AddBook(book);

            Console.WriteLine("******Welcome to my library**********");

            int choice = -1;
            bool invalidChoice = false;

            while (choice != 0 || invalidChoice)
            {
                Console.WriteLine("1. Add a book to the library");
                Console.WriteLine("2. Rent a book from the library");
                Console.WriteLine("3. Return a book to the library");
                Console.WriteLine("0. Exit");
                Console.Write("Please choose an option:  ");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    invalidChoice = true;
                    Console.WriteLine("Invalid choice. Try again......");
                    continue;
                }
                invalidChoice = false;

                //if (choice ==1)
                //{

                //}
                //else  

                switch (choice)
                {
                    case 1:
                        Console.Write("Title: ");
                        var title = Console.ReadLine();
                        Console.Write("Price: ");
                        decimal price;
                        if (!decimal.TryParse(Console.ReadLine(), out price))
                            return;
                        
                        var book = new Book();
                        book.Title = title;
                        book.Price = price;
                        book.PublishedYear = DateTime.Now;
                        book.AuthorId = 1;

                        Library.AddBook(book);
                        break;
                    case 2:


                        break;
                    case 3:
                        break;
                    default:
                        break;
                };
            }
            
        }
    }
}
