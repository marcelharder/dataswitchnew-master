using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class ValveSurgery
    {
        public int? ProcedureId { get; set; }
        public int? PatientId { get; set; }
        public int? AorticImplant { get; set; }
        public string AorticExplant { get; set; }
        public string AorticSize { get; set; }
        public int? AorticType { get; set; }
        public string AorticSizeExp { get; set; }
        public int? AorticTypeExp { get; set; }
        public int? MitralImplant { get; set; }
        public string MitralExplant { get; set; }
        public string MitralSize { get; set; }
        public int? MitralType { get; set; }
        public string MitralSizeExp { get; set; }
        public int? MitralTypeExp { get; set; }
        public int? TricuspidImplant { get; set; }
        public string TricuspidExplant { get; set; }
        public string TricuspidSize { get; set; }
        public int? TricuspidType { get; set; }
        public string TricuspidSizeExp { get; set; }
        public int? TricuspidTypeExp { get; set; }
        public int? PulmonicImplant { get; set; }
        public string PulmonicExplant { get; set; }
        public string PulmonicSize { get; set; }
        public int? PulmonicType { get; set; }
        public string PulmonicSizeExp { get; set; }
        public int? PulmonicTypeExp { get; set; }
        public int? AorticProcedure { get; set; }
        public int? MitralProcedure { get; set; }
        public int? TricuspidProcedure { get; set; }
        public int? PulmonicProcedure { get; set; }
        public string AorticAetiology { get; set; }
        public string MitralAetiology { get; set; }
        public string TricuspidAetiology { get; set; }
        public string PulmonicAetiology { get; set; }
        public string AorticModel { get; set; }
        public string AorticModelExp { get; set; }
        public string MitralModel { get; set; }
        public string MitralModelExp { get; set; }
        public string TricuspidModel { get; set; }
        public string TricuspidModelExp { get; set; }
        public string PulmonicModel { get; set; }
        public string PulmonicModelExp { get; set; }
        public string AorticSerialImp { get; set; }
        public string AorticSerialExp { get; set; }
        public string MitralSerialImp { get; set; }
        public string MitralSerialExp { get; set; }
        public string TricuspidSerialImp { get; set; }
        public string TricuspidSerialExp { get; set; }
        public string PulmonicSerialImp { get; set; }
        public string PulmonicSerialExp { get; set; }
        public int? AorticValveId { get; set; }
        public int? MitralValveId { get; set; }
        public int? TricuspidValveId { get; set; }
        public int? PulmonicValveId { get; set; }
        public string Memo { get; set; }
        public string Combined { get; set; }
    }
}
