using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class Cellule
    {
        public int idCelllule { get; set; }
        public string libelleCellule { get; set; }

        
        public virtual ICollection<Materiel> MATERIEL { get; set; }
        public virtual ICollection<Tickets> TICKETS { get; set; }
    }
}