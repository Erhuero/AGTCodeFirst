using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class Profil
    {
        public int idProfil { get; set; }
        public string nomProfil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilisateur> UTILISATEUR { get; set; }
    }
}