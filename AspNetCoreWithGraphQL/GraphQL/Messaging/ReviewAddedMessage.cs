using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreWithGraphQL.GraphQL.Messaging
{
    public class ReviewAddedMessage
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
    }
}
