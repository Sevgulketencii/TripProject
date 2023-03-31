﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactDescription { get; set; }
        public string ContactMail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMap { get; set; }
        public bool ContactStatus { get; set; }
    }
}
