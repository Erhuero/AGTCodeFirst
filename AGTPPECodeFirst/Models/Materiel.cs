using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class Materiel
    {

        public string numeroSerieMateriel { get; set; }
        public string emplacementMateriel { get; set; }
        public string modeleMateriel { get; set; }
        public string ipMateriel { get; set; }
        public string typeIpMateriel { get; set; }
        public string numInfologMateriel { get; set; }
        public string celluleMateriel { get; set; }
        public string etatMateriel { get; set; }
        public string numeroChariot { get; set; }
        public Nullable<int> idUtilisateur { get; set; }
        public string typeConnexion { get; set; }
        public int idCelllule { get; set; }
        public int idBarre { get; set; }
        public string typeIP { get; set; }

        public virtual Barre BARRE { get; set; }
        public virtual Cellule CELLULE { get; set; }
        public virtual TypeConnexion TYPECONNEXION1 { get; set; }
        public virtual Utilisateur UTILISATEUR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> TICKETS { get; set; }
        public virtual TypeIP TYPEIP1 { get; set; }

    }
}