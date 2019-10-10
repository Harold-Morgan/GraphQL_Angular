using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_GrahQL.GraphQL
{
    public class GraphQLSchema : Schema
    {
            public GraphQLSchema(IDependencyResolver resolver) : base(resolver)
            {
                Query = resolver.Resolve<ReservationQuery>();
            }
    }
}
