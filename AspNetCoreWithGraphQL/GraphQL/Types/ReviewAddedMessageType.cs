using AspNetCoreWithGraphQL.GraphQL.Messaging;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithGraphQL.GraphQL.Types
{
    public class ReviewAddedMessageType : ObjectGraphType<ReviewAddedMessage>
    {
        public ReviewAddedMessageType()
        {
            Field(t => t.ProductId);
            Field(t => t.Title);
        }
    }
}
