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

        /// <summary>
        /// Collection of books
        /// </summary>
        public static List<Book> Books { get; set; }

        #endregion

        #region Constructors
        static Library()
        {
            Books = new List<Book>();
        }
        #endregion


        #region Methods
        public static void AddBook (Book book)
        {
            using (var model = new LibraryModel())
            {
                model.Books.Add(book);
            }
        }

        public static void PrintBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine("Title: {0}, ISBN: {1}, Price: {2}, Published: {3}",
                    book.Title, book.ISBN, book.Price, book.PublishedYear);

            
            }

        }

        #endregion
    }
}
