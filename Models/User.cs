using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ValkyrieIMS.Models {
    public class User: IdentityUser {
        public string FirstName { get; set;}
        public string LastName { get; set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}