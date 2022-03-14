using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleLibrary
{
    public class Filiere
    {
        public int FiliereId { get; set; }
        public string FiliereNom { get; set; }

        public ICollection<Etudiant> Etudiants { get; set; }
    }
}
