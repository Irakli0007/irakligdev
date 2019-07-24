using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace irakligdev.Models
{
    [Table("Phrases_EN")]
    public class Phrases_EN
    {
        [Key]
        public Guid guid { get; set; }
        
        public string phrase { get; set; }




    }
}