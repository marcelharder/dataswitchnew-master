using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class FinalPrintDischarge
    {
        public int AdmissionId { get; set; }
        public string Regel1 { get; set; }
        public string Regel2 { get; set; }
        public string Regel3 { get; set; }
        public string Regel4 { get; set; }
        public string Regel5 { get; set; }
        public string Regel6 { get; set; }
        public string Regel7 { get; set; }
        public string Regel8 { get; set; }
        public string Regel9 { get; set; }
        public string Regel10 { get; set; }
        public string Regel11 { get; set; }
        public string Regel12 { get; set; }
        public string Regel13 { get; set; }
        public string Regel14 { get; set; }

        public virtual Admission Admission { get; set; }
    }
}
