using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class NveauUrgenceTicket
    {
   

        public int idUrgence { get; set; }
        public string libelleUrgence { get; set; }

        
        public virtual ICollection<Tickets> TICKETS { get; set; }
    }
}