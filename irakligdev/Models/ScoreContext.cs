﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace irakligdev.Models
{
    public class ScoreContext : DbContext
    {
        public DbSet<Score> Score { get; set; }

        public ScoreContext() : base("Start")
        {

        }

    }
}