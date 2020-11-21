using MovieDiary.Models;
using System;
using System.Collections.Generic;

namespace MovieDiary.Data
{
    public interface IReviewRepo
    {
        bool SaveChanges();
        IEnumerable<ReviewModel> GetAllReviews();
        ReviewModel GetReviewById(int id);
        void CreateReview(ReviewModel review);
        void DeleteReview(ReviewModel review);
    }
}
