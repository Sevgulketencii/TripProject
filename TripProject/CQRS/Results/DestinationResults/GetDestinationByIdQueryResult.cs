using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.CQRS.Results.DestinationResults
{
    public class GetDestinationByIdQueryResult
    {
        public int destinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
    }
}
