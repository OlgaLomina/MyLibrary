using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LibraryAPI
{
    public enum RentalTypes
    {
        Book,
        Audio,
        Video
    }
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

        public static List<Book> GetBooks()
        {
            using (var model = new LibraryModel())
            {
                //var books = model.Books.Include(b => b.Author);
                var books = model.Books.Include("Author").Where(b => b.Count > 0);
                return books.ToList<Book>();

            }
        }

        public static int BorrowBook(int id, string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
            {
                throw new ArgumentNullException("You need to be logged in to borrow a book!");
            }
                using (var model = new LibraryModel())
            {
                var account = model.Accounts.Where(a => a.EmailAddless == emailAddress).FirstOrDefault();
                if (account == null)
                {
                    account = new Account();
                    account.EmailAddless = emailAddress;
                    model.Accounts.Add(account);
                    model.SaveChanges();
                }
                
                var book = model.Books.Where(book => book.ISBN == id).FirstOrDefault();
                if (book == null)
                {
                    throw new ArgumentException("Book not found!");
                }
                book.Count--;

                var rental = new Rental();
                rental.AccountId = account.AccountId;
                rental.RentalType = RentalTypes.Book;
                rental.Id = id;
                model.Rentals.Add(rental);
                model.SaveChanges();

                return rental.RentalId;

            }
        }

        public static List<Book> GetMyRentals(string emailAddress)
        {
            var model = new LibraryModel()
            var account = model.Accounts.Where(a => a.EmailAddless == emailAddress).FirstOrDefault();
            if (account == null)
            {
                throw new ArgumentException("User account not found ");
            }
            var books = new List<Book>();
            var rentals = model.Rentals.Where(r => r.AccountId == account.AccountId);
            foreach (var rental in rentals)
            {
                books.Add(model.Books.Where(b => b.ISBN == rental.Id).FirstOrDefault();
            }
        }

        #endregion
    }
}
