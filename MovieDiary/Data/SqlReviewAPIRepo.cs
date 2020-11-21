using MovieDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDiary.Data
{
    public class SqlReviewAPIRepo : IReviewRepo
    {
        private readonly ReviewContext _context;
        public SqlReviewAPIRepo(ReviewContext context)
        {
            _context = context;
        }
        public void CreateReview(ReviewModel review)
        {
            if (review == null) throw new ArgumentNullException(nameof(review));

            _context.ReviewItems.Add(review);
            
        }

        public void DeleteReview(ReviewModel review)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewModel> GetAllReviews()
        {

            return _context.ReviewItems.ToList(); ;
        }

        public ReviewModel GetReviewById(int id)
        {
            return _context.ReviewItems.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
