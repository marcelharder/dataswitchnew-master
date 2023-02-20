using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class EusurHistory
    {
        public int PatientId { get; set; }
        public int? SymptomStatus { get; set; }
        public int? DyspneaNyha { get; set; }
        public int? Chf { get; set; }
        public int? NumberPrevMi { get; set; }
        public int? OtherNoncardiacType { get; set; }
        public int? PrevMiHours { get; set; }
        public int? PrevMiDays { get; set; }
        public string PreopInotropes { get; set; }
        public string PreopVentilated { get; set; }
        public string PreopPm { get; set; }
        public int? PreopPmType { get; set; }
        public string PreopIabp { get; set; }
        public string FailedIntervention { get; set; }
        public string FailedInterventionTime { get; set; }
        public double? LastCreatinine { get; set; }
        public double? LastSodium { get; set; }
        public double? LastPtt { get; set; }
        public string LiverDisease { get; set; }
        public string CerebrovascularDisease { get; set; }
        public int? CvaMonths { get; set; }
        public int? CvaWeeks { get; set; }
        public int? TiaMonths { get; set; }
        public int? TiaWeeks { get; set; }
        public int? CarotidPercentage { get; set; }
        public string OtherCentralNeuro { get; set; }
        public string OtherPeriphNeuro { get; set; }
        public string Copd { get; set; }
        public string SteroidUse { get; set; }
        public string Asthma { get; set; }
        public string BronchoUse { get; set; }
        public int? RenalFailureType { get; set; }
        public int? CopdSeverity { get; set; }
        public int? CervascDisType { get; set; }
        public string PreviousCs { get; set; }
        public string PreviousCard { get; set; }
        public string Bloodgroup { get; set; }
        public string Rhesus { get; set; }
        public int? IsInterventionalCardiology { get; set; }
        public int? IsPreviousInterventions { get; set; }
    }
}
