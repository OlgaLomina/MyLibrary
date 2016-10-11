using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    /// <summary>
    /// Definition of a book
    /// 
    /// </summary>


    class Book
    {
        #region Properties
        /// <summary>
        /// ISBN of the book
        /// </summary>
        public int ISBN { get; set; }
        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }

        public DateTime PublishedYear { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        #endregion

        #region Methods
        public void Checkout()
        {
            //Count = Count - 1;
            Count--;
        }

        public void Return()
        {
            Count++;
        }

        #endregion
    }
}
