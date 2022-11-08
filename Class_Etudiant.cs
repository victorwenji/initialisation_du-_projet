using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationCompetence
{
    class Class_Etudiant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Referentiel { get; set; }
        public bool A_RNCP34408BC01 { get; set; }

        public DateTime Date = DateTime.Now;
        public bool A1 { get; set; }
        public bool A2 { get; set; }
        public bool A3 { get; set; }
        public bool A4 { get; set; }
        public bool A5 { get; set; }
        public bool A6 { get; set; }
        public bool A7 { get; set; }
        public bool A8 { get; set; }

        public Class_Etudiant(DateTime date)
        {
            Date = date;
        }

        public Class_Etudiant(string id, string name, string lastName, string referentiel)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Referentiel = referentiel;
        }
        public Class_Etudiant
           (
               bool a_RNCP34408BC01,bool a1,
               bool a2,
               bool a3,
               bool a4,
               bool a5,
               bool a6,
               bool a7,
               bool a8
              
           )
        {
            A_RNCP34408BC01 = a_RNCP34408BC01;
            A1 = a1;
            A2 = a2;
            A3 = a3;
            A4 = a4;
            A5 = a5;
            A6 = a6;
            A7 = a7;
            A8 = a8;
            
        }

    }
}
