using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ValkyrieIMS.Models {
    public class User: IdentityUser {
        public string FirstName { get; set;}
        public string LastName { get; set;}
    }
}