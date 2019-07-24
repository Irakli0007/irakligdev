using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace irakligdev.Models
{
    [Table("Words_Relation")]
    public class Words_Relation
    {
        [Key]
        public Guid guid { get; set; }
        
        public Guid Word_EN_Guid { get; set; }
        public Guid Word_KR_Guid { get; set; }




    }
}