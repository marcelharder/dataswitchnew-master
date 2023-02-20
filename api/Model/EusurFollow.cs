using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class EusurFollow
    {
        public int PatientId { get; set; }
        public DateTime? DateSeen { get; set; }
        public DateTime? LateDead { get; set; }
        public byte? NyhaClass { get; set; }
        public byte? CcsClass { get; set; }
        public string CauseDeath { get; set; }
        public string LateMortality { get; set; }
        public string DateSeenString { get; set; }
        public string LateDeadString { get; set; }
    }
}
