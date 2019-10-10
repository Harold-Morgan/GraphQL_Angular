using Angular_GrahQL.Entities;
using Angular_GrahQL.GraphQLTypes;
using Angular_GrahQL.Repositories;
using GraphQL.Types;
using System.Collections.Generic;
using System.Security.Claims;

namespace Angular_GrahQL.GraphQL
{
    internal class ReservationQuery : ObjectGraphType
    {
        public ReservationQuery(ReservationRepository reservationRepository)
        {
            

        }
    }
}