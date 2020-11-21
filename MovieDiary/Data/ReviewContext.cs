using Microsoft.EntityFrameworkCore;
using MovieDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDiary.Data
{
    public class ReviewContext : DbContext
    {
        public ReviewContext(DbContextOptions<ReviewContext> options) : base(options)
        {

        }
        public DbSet<ReviewModel> ReviewItems { get; set; }
    }
}
