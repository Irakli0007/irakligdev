using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace irakligdev.Models
{
    [Table("User")]
    public partial class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }
        public byte[] Password { get; set; }


        public string SPassword;


        
    }
}