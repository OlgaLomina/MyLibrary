using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        public string EmailAddless { get; set; }
        
        public virtual ICollection<Rental> Rentals { get; set; }


    }
}
