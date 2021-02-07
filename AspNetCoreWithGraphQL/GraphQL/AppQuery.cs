using AspNetCoreWithGraphQL.GraphQL.Types;
using AspNetCoreWithGraphQL.Repositories;
using GraphQL.Types;

namespace AspNetCoreWithGraphQL.GraphQL
{
    public class AppQuery : ObjectGraphType
    {

        public AppQuery(ProductRepository repository)
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => repository.GetAll()
          );
        }

    }
}
