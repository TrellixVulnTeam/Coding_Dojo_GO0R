using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace the_wall.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage="Email address is required.")]
        [EmailAddress(ErrorMessage="Enter a valid email address.")]
        public string LoginEmail {get;set;}

        [Required(ErrorMessage="Password is required.")]
        [DataType(DataType.Password)]
        public string LoginPassword {get;set;}
    }
}