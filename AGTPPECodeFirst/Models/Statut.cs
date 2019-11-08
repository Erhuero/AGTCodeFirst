using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class Statut
    {

        public int etatStatut { get; set; }
        public string libelleStatut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> TICKETS { get; set; }
    }
}