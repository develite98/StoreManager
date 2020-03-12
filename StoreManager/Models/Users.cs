using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManager.Models
{
    public class Users
    {
   
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string password { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage = "Email not correct")]
        public string eMail { get; set; }


    }
}
