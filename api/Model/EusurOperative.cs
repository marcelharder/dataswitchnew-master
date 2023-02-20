using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class EusurOperative
    {
        public int? ProcedureId { get; set; }
        public int? SkinIncisionStartHr { get; set; }
        public int? SkinIncisionStopHr { get; set; }
        public int? SkinIncisionStopMin { get; set; }
        public int? SkinIncisionStartMin { get; set; }
        public int? TotalTime { get; set; }
        public string SurgeryBeforeNextWorkingDay { get; set; }
        public string Anaesthesist { get; set; }
        public string Perfusionist { get; set; }
        public string Nurse1 { get; set; }
        public string Nurse2 { get; set; }
        public string FreeText { get; set; }
        public string StatusEl { get; set; }
        public string StatusUr { get; set; }
        public string StatusEm { get; set; }
        public string StatusSalvage { get; set; }
        public int? Sequence { get; set; }
    }
}
