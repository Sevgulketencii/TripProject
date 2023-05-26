using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripProject.CQRS.Results.DestinationResults;

namespace TripProject.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {

        private readonly Context _context;

        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }


        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.DestinationDbSet.Select(x => new GetAllDestinationQueryResult()
            {
                ID = x.DestinationID,
                destinationCapacity = x.Capacity,
                destinationDayNight = x.DayNight,
                destinationName = x.City,
                destinationPrice = x.Price
                
            }).AsNoTracking().ToList();
            return values;
        }
    }
}
