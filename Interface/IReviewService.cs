using Online_Store.DTO;
using Online_Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.Interface
{
    public interface IReviewService
    {
        Task<List<Review>> GetReviews();
        Task<Review> GetSingleReviewById(Guid id);
        Task AddReview(CreateReviewDTO review);
        Task UpdateReviewById(Guid id, Review review);
        Task DeleteSingleReviewById(Guid id);
        Task<Review> GetReviewsByProductId(Guid id);
    }
}
