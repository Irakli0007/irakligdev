using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace irakligdev.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        public UserContext() : base("Start")
        {

        }

    }
}