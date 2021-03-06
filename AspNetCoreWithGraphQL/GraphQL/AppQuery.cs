﻿using AspNetCoreWithGraphQL.GraphQL.Types;
using AspNetCoreWithGraphQL.Repositories;
using GraphQL.Types;

namespace AspNetCoreWithGraphQL.GraphQL
{
    public class AppQuery : ObjectGraphType
    {

        public AppQuery(ProductRepository repository, ProductReviewRepository reviewRepository)
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => repository.GetAll()
            );

            Field<ProductType>(
                "product",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return repository.GetProduct(id);
                }
            );

            Field<ListGraphType<ProductReviewType>>(
               "reviews",
               arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "productId" }),
               resolve: context =>
               {
                   var id = context.GetArgument<int>("productId");
                   return reviewRepository.GetForProduct(id);
               });
        }

    }
}
