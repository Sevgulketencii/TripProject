using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Guide
    {
        [Key]
        public int GuideID { get; set; }
        public string GuideName { get; set; }
        public string GuideDescription { get; set; }
        public string GuideImage { get; set; }
        public string GuideTwitter { get; set; }
        public string GuideInstagram { get; set; }
        public bool GuideStatus { get; set; }
    }
}
