using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDiary.Dtos
{
    public class ReviewReadDto
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
    }
}
