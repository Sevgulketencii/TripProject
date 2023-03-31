﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public string Price { get; set; }
        public string RouteImage { get; set; }
        public string RouteDescription { get; set; }
        public string Capacity { get; set; }
        public bool RouteStatus { get; set; }
    }
}
