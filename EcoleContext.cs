using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EcoleLibrary
{
    public class EcoleContext :DbContext
    {
        public EcoleContext() : base("name=ecolecnx")
        {

        }

        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Filiere> Filieres { get; set; }
    }
}
