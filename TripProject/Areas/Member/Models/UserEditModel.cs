using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripProject.Areas.Member.Models
{
    public class UserEditModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string password2 { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string imageurl { get; set; }
        public string gender { get; set; }
        public IFormFile image { get; set; }
    }
}
