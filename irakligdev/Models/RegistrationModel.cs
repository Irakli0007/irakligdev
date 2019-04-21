using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace irakligdev.Models
{
    public class RegistrationModel
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }

    }
}