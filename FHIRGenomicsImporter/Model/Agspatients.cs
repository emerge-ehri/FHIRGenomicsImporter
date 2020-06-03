using System;
using System.Collections.Generic;

namespace FHIRGenomicsImporter.Model
{
    public partial class Agspatients
    {
        public Agspatients()
        {
            Agsobservations = new HashSet<Agsobservations>();
            AgspatientAudits = new HashSet<AgspatientAudits>();
            AgsresultPatients = new HashSet<AgsresultPatients>();
        }

        public int PatientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Mrn { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Agsobservations> Agsobservations { get; set; }
        public virtual ICollection<AgspatientAudits> AgspatientAudits { get; set; }
        public virtual ICollection<AgsresultPatients> AgsresultPatients { get; set; }
    }
}
