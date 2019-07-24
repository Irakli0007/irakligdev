using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace irakligdev.Models
{
    [Table("Words_KR")]
    public class Words_KR
    {
        [Key]
        public Guid guid { get; set; }
        
        public string word { get; set; }




    }
}