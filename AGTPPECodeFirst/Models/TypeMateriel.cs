using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class TypeMateriel
    {
        public string typeMateriel1 { get; set; }
        public string libelleMateriel { get; set; }

        
        public virtual ICollection<Tickets> TICKETS { get; set; }
    }
}