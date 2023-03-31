
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        public string AboutTitle { get; set; }
        public string AboutDesciription { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutTitle2 { get; set; }
        public string AboutDesciription2 { get; set; }
        public bool AboutStatus { get; set; }
    }
}
