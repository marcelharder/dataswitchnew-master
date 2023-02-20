using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class Svr
    {
        public int ProcedureId { get; set; }
        public double? BalloonSize { get; set; }
        public string BalloonVendor { get; set; }

        public virtual ProcedureInfo Procedure { get; set; }
    }
}
