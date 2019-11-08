using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AGTPPECodeFirst.Models
{
    public class Utilisateur
    {

        public int idUtilisateur { get; set; }
        public string nomUtilisateur { get; set; }
        public string prenomUtilisateur { get; set; }
        public string telephoneUtilisateur { get; set; }
        public string mailUtilisateur { get; set; }
        public string gradeUtilisateur { get; set; }
        public int idProfil { get; set; }
        public int idUtilisateur_Autoreinscription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materiel> MATERIEL { get; set; }
        public virtual Profil PROFIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> TICKETS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilisateur> UTILISATEUR1 { get; set; }
        public virtual Utilisateur UTILISATEUR2 { get; set; }

    }
}