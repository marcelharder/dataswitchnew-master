using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class EusurCpb
    {
        public int ProcedureId { get; set; }
        public int? PatientId { get; set; }
        public int? OpcabAttempt { get; set; }
        public int? CpbUsed { get; set; }
        public int? A1 { get; set; }
        public int? A2 { get; set; }
        public int? A3 { get; set; }
        public int? A4 { get; set; }
        public int? V1 { get; set; }
        public int? V2 { get; set; }
        public int? V3 { get; set; }
        public int? V4 { get; set; }
        public int? AoOccl { get; set; }
        public int? LongIsch { get; set; }
        public string BloodPerfusion { get; set; }
        public string CardioplTiming { get; set; }
        public string CardioplTemp { get; set; }
        public string CnsProtect { get; set; }
        public int? CnsTime1 { get; set; }
        public int? CnsTime2 { get; set; }
        public int? CnsTime3 { get; set; }
        public string DeepHypo { get; set; }
        public string DeepHypoRcp { get; set; }
        public string AcpCirc { get; set; }
        public string OtherCnsProtect { get; set; }
        public string NonCmprotect { get; set; }
        public short? NonCmprotectType { get; set; }
        public DateTime? IabpDate { get; set; }
        public string Myoplasty { get; set; }
        public int? CpbStartHr { get; set; }
        public int? CpbStartMin { get; set; }
        public int? CpbStopHr { get; set; }
        public int? CpbStopMin { get; set; }
        public int? ClampStartHr { get; set; }
        public int? ClampStartMin { get; set; }
        public int? ClampStopHr { get; set; }
        public int? ClampStopMin { get; set; }
        public string OtherCardiacSupport { get; set; }
        public string CardiacSupport { get; set; }
    }
}
