﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace irakligdev.DBEntities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        
    }
}