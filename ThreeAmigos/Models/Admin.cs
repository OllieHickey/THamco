using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThreeAmigos.Models
{
    public class Admin
    {
        [Key]
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StaffTasks { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        
    }
}