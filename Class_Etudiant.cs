using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationCompetence
{
    internal class Class_Etudiant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Referentiel { get; set; }

        public Class_Etudiant(string id, string name, string lastName, string referentiel)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Referentiel = referentiel;
        }
    }
}
