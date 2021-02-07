using AspNetCoreWithGraphQL.Data.Entities;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreWithGraphQL.GraphQL.Types
{
    public class ProductReviewType : ObjectGraphType<ProductReview>
    {
        public ProductReviewType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Review);
        }
    }
}
