﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class SubAbout
    {
        [Key]
        public int SubAboutID { get; set; }
        public string SubAboutTitle { get; set; }
        public string SubAboutDesciription { get; set; }
    }
}
