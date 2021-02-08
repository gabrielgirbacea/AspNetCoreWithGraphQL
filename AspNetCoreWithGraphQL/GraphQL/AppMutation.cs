using AspNetCoreWithGraphQL.Data.Entities;
using AspNetCoreWithGraphQL.GraphQL.Types;
using AspNetCoreWithGraphQL.Repositories;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreWithGraphQL.GraphQL
{
    public class AppMutation : ObjectGraphType
    {
        public AppMutation(ProductReviewRepository reviewRepository)
        {
            FieldAsync<ProductReviewType>(
                "createReview",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ProductReviewInputType>> { Name = "review" }),
                resolve: async context =>
                {
                    var review = context.GetArgument<ProductReview>("review");
                    return await context.TryAsyncResolve(
                        async c => await reviewRepository.AddReview(review));
                });
        }
    }
}
