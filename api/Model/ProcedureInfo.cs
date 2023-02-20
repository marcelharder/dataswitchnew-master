using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class ProcedureInfo
    {
        public int ProcedureId { get; set; }
        public int? AdmissionId { get; set; }
        public double? PatientId { get; set; }
        public short? RecordId { get; set; }
        public string FdType { get; set; }
        public string ParticipantId { get; set; }
        public DateTime? SurgeryDate { get; set; }
        public int? Age { get; set; }
        public string Cardiologist { get; set; }
        public string CardiologistCity { get; set; }
        public string CardiologistPhone { get; set; }
        public string Physician { get; set; }
        public string PhysicianCity { get; set; }
        public string ReferringPhysicianPhone { get; set; }
        public int? Sent { get; set; }
        public int? RecComp { get; set; }
        public string Version { get; set; }
        public string StsDataVersion { get; set; }
        public int? LosAdmitSurg { get; set; }
        public int? LosSurgDischarge { get; set; }
        public int? Refcardno { get; set; }
        public string SurgeryDateString { get; set; }

        public virtual FinalPrint FinalPrint { get; set; }
        public virtual Svr Svr { get; set; }
    }
}
