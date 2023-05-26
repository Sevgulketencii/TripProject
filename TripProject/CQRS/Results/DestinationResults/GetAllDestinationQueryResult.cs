using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.CQRS.Results.DestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int ID { get; set; }
        public string destinationName { get; set; }
        public double destinationPrice { get; set; }
        public string destinationCapacity { get; set; }
        public string destinationDayNight { get; set; } 
    }
}
