using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThreeAmigos.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string CardType { get; set; }
        public int DebitCreditCardNumber { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int CVV { get; set; }

    }
}