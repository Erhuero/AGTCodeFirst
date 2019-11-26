using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class Barre
    {
        public int idBarre { get; set; }
        public string libelleBarre { get; set; }

      
        public virtual ICollection<Materiel> MATERIEL { get; set; }
       
        public virtual ICollection<Tickets> TICKETS { get; set; }
    }
}