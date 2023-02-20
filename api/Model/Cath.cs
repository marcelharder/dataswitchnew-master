using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class Cath
    {
        public int PatientId { get; set; }
        public DateTime? CathDate { get; set; }
        public string CathDuringAdmission { get; set; }
        public string CathAtSameHospital { get; set; }
        public int? NumDisCoronVess { get; set; }
        public string LeftMain { get; set; }
        public string HemoData { get; set; }
        public DateTime? HemoDate { get; set; }
        public int? Ef { get; set; }
        public int? EfMethod { get; set; }
        public double? Co { get; set; }
        public double? Ci { get; set; }
        public int? Lvedp { get; set; }
        public int? Pa1 { get; set; }
        public int? Pa2 { get; set; }
        public int? Pam { get; set; }
        public int? Paw { get; set; }
        public int? AorticDisease { get; set; }
        public string AorticStenosis { get; set; }
        public int? AorticInsufficiency { get; set; }
        public int? AorticEtiology { get; set; }
        public int? AorticGradient { get; set; }
        public int? MitralDisease { get; set; }
        public string MitralStenosis { get; set; }
        public int? MitralInsufficiency { get; set; }
        public int? MitralEtiology { get; set; }
        public int? MitralGradient { get; set; }
        public int? TricuspidDisease { get; set; }
        public string TricuspidStenosis { get; set; }
        public int? TricuspidInsufficiency { get; set; }
        public int? TricuspidEtiology { get; set; }
        public int? TricuspidGradient { get; set; }
        public int? PulmonicDisease { get; set; }
        public string PulmonicStenosis { get; set; }
        public int? PulmonicInsufficiency { get; set; }
        public int? PulmonicEtiology { get; set; }
        public int? PulmonicGradient { get; set; }
        public int? IntvlOr { get; set; }
        public int? HemoDataEfDone { get; set; }
        public int? HdpaMeanDone { get; set; }
        public int? LvFunction { get; set; }
        public string CoronariesDone { get; set; }
        public string EfDone { get; set; }
        public string LvedpDone { get; set; }
        public string RightheartDone { get; set; }
        public string CathDateString { get; set; }
        public string PasysDone { get; set; }
        public string PameanDone { get; set; }
        public string PawpDone { get; set; }
    }
}
