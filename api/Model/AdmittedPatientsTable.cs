using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class AdmittedPatientsTable
    {
        public string PatientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Op { get; set; }
        public string Mrn { get; set; }
    }
}
