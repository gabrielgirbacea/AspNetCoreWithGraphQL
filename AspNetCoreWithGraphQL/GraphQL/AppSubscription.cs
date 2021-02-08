using AspNetCoreWithGraphQL.GraphQL.Messaging;
using GraphQL.Resolvers;
using GraphQL.Types;

namespace AspNetCoreWithGraphQL.GraphQL
{
    public class AppSubscription : ObjectGraphType
    {
        public AppSubscription(ReviewMessageService messageService)
        {
            Name = "Subscription";
            AddField(new EventStreamFieldType()
            {
                Name = "reviewAdded",
                Type = typeof(ReviewAddedMessage),
                Resolver = new FuncFieldResolver<ReviewAddedMessage>(c => c.Source as ReviewAddedMessage),
                Subscriber = new EventStreamResolver<ReviewAddedMessage>(c => messageService.GetMessages())
            });
        }
    }
}