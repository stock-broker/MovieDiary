using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDiary.Models
{
    public class ReviewModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string MovieTitle { get; set; }
        [MaxLength(140)]
        public string Review { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}
