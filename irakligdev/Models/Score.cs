using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace irakligdev.Models
{
    [Table("Score")]
    public class Score
    {
        [Key]
        public int Id { get; set; }

        public int Value { get; set; }

        public Score()
        {
            Value = 1;
        }

        public Score(int score)
        {
            Value = score;
        }

    }
}