using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public int ReservationCount { get; set; }
        public string ReservationDestination { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Description { get; set; }
        public string ReservationStatus { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
