using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoleLibrary
{
    public class Etudiant
    {
        public int EtudiantID { get; set; }
        public string EtudiantNom { get; set; }

        public Filiere Filiere { get; set; }
    }
}
