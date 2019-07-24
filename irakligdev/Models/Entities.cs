using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace irakligdev.Models
{
    public class Entities : DbContext
    {
        public DbSet<Words_EN> Words_EN { get; set; }
        public DbSet<Words_KR> Words_KR { get; set; }
        public DbSet<Words_Relation> Words_Relation { get; set; }

        public DbSet<Phrases_EN> Phrases_EN { get; set; }
        public DbSet<Phrases_KR> Phrases_KR { get; set; }
        public DbSet<Phrases_Relation> Phrases_Relation { get; set; }


        public Entities() : base("ConnectionString")
        {

        }



    }
}