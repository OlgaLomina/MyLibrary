using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public static class Library
    {
        #region Properties
        public static string Name { get; set; }

        public static string Address { get; set; }

        #endregion

        #region Methods
        public static void AddBook (Book book)
        {
            using (var model = new LibraryModel())
            {
                model.Books.Add(book);
                model.SaveChanges();
            }
            
        }

        public static void PrintBooks()
        {
            using (var model = new LibraryModel())
            { 
                foreach (var book in model.Books)
                {
                    Console.WriteLine("Title: {0}, ISBN: {1}, Price: {2}, Published: {3}",
                        book.Title, book.ISBN, book.Price, book.PublishedYear);


                }
            }
        }

        #endregion
    }
}
