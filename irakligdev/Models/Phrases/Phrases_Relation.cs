using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace irakligdev.Models
{
    [Table("Phrases_Relation")]
    public class Phrases_Relation
    {
        [Key]
        public Guid guid { get; set; }
        
        public Guid Phrase_EN_Guid { get; set; }
        public Guid Phrase_KR_Guid { get; set; }



    }
}