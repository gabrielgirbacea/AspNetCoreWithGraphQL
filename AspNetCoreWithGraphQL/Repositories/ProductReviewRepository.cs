using AspNetCoreWithGraphQL.Data;
using AspNetCoreWithGraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithGraphQL.Repositories
{
    public class ProductReviewRepository
    {
        private readonly AppDbContext _context;

        public ProductReviewRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<ProductReview>> GetForProduct(int productId)
        {
            return await _context.ProductReviews.Where(pr => pr.ProductId == productId).ToListAsync();
        }

        public async Task<ILookup<int, ProductReview>> GetForProducts(IEnumerable<int> productIds)
        {
            var reviews = await _context.ProductReviews.Where(pr => productIds.Contains(pr.ProductId)).ToListAsync();
            return reviews.ToLookup(r => r.ProductId);
        }

        public async Task<ProductReview> AddReview(ProductReview review)
        {
            _context.ProductReviews.Add(review);
            await _context.SaveChangesAsync();
            return review;
        }
    }
}
