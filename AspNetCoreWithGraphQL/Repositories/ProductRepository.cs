using AspNetCoreWithGraphQL.Data;
using AspNetCoreWithGraphQL.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreWithGraphQL.Repositories
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            this._context = context;
        }

        public Task<List<Product>> GetAll()
        {
            return _context.Products.ToListAsync();
        }
    }
}
