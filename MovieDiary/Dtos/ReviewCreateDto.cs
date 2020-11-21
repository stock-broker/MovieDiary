using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDiary.Dtos
{
    public class ReviewCreateDto
    {
        
        [Required]
        [MaxLength(50)]
        public string MovieTitle { get; set; }
        [MaxLength(140)]
        public string Review { get; set; }
        [Required]
        public int Rating { get; set; }

    }
}
