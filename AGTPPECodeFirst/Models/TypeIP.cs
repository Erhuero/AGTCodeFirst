﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class TypeIP
    {
        public string typeIP1 { get; set; }
        public string libelleIP { get; set; }

       
        public virtual ICollection<Materiel> MATERIEL { get; set; }
    }
}