using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class PatientDemographic
    {
        public int PatientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string MedRecNumber { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Ssno { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public int? Race { get; set; }
        public int? BirthCountry { get; set; }
        public string DobString { get; set; }

        public virtual Cockpit Cockpit { get; set; }
    }
}
