using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class Admission
    {
        public int AdmissionId { get; set; }
        public string Hosno { get; set; }
        public int? PatientId { get; set; }
        public string Hospital { get; set; }
        public string HospState { get; set; }
        public string HospZip { get; set; }
        public string Insurer { get; set; }
        public string SameDayElective { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string TransferFromFac { get; set; }
        public string OtherHospPerform { get; set; }
        public int? LosAdmitDischarge { get; set; }
        public string CostLink { get; set; }
        public string StsLink { get; set; }
        public string DcMedsAspirin { get; set; }
        public string AceInhibitorsDischarge { get; set; }
        public string BetaBlockersDischarge { get; set; }
        public string LipidLoweringDischarge { get; set; }
        public string OtherAntiplateletsDischarge { get; set; }
        public string DischargeLocation { get; set; }
        public string Diagnosis { get; set; }

        public virtual FinalPrintDischarge FinalPrintDischarge { get; set; }
    }
}
