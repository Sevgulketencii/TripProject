using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripProject.CQRS.Queries.DestinationQueries;
using TripProject.CQRS.Results.DestinationResults;

namespace TripProject.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;

        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIdQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.DestinationDbSet.Find(query.ID);
            var body = new GetDestinationByIdQueryResult()
            {
                City = values.City,
                DayNight = values.DayNight,
                destinationID = values.DestinationID,
                Price = values.Price,
            };
            return body;
        }
    }
}
