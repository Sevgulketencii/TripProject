﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class About2
    {
        [Key]
        public int About2ID { get; set; }
        public string About2Title { get; set; }
        public string About2Title2 { get; set; }
        public string About2Description { get; set; }
        public string About2Img { get; set; }

    }
}