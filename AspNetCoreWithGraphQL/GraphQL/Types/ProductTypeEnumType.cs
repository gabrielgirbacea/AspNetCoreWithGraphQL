using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreWithGraphQL.GraphQL.Types
{
    public class ProductTypeEnumType : EnumerationGraphType<Data.ProductTypeEnum>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The type of product";
        }
    }
}
