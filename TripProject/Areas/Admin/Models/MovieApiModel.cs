using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Admin.Models
{
    public class MovieApiModel
    {
        public int rank { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string rating { get; set; }
        public string year { get; set; }
    }
}
