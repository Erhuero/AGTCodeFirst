using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class TypeConnexion
    {

        public string typeConnexion1 { get; set; }
        public string descriptionConnexion { get; set; }

      
        public virtual ICollection<Materiel> MATERIEL { get; set; }
    }
}