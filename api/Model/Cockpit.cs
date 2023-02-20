using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class Cockpit
    {
        public int PatientId { get; set; }
        public string Anamnese { get; set; }
        public short? Pulse { get; set; }
        public string HeadNeck { get; set; }
        public string TrCirc { get; set; }
        public string TrPulm { get; set; }
        public string TrDig { get; set; }
        public string Extremities { get; set; }
        public short? VaricesR { get; set; }
        public short? VaricesL { get; set; }
        public short? PeriphPulse { get; set; }
        public string EcgRhythm { get; set; }
        public short? EcgBpm { get; set; }
        public short? EcgAxis { get; set; }
        public short? EcgCondPr { get; set; }
        public short? EcgCondQrs { get; set; }
        public short? EcgCondQt { get; set; }
        public string EcgAdditional { get; set; }
        public string Echo { get; set; }
        public string ButtonString { get; set; }
        public string LungFunction { get; set; }
        public string Radiology { get; set; }
        public string Planning { get; set; }
        public string Todo { get; set; }
        public string Research { get; set; }
        public string Discussion { get; set; }
        public string Onderzoek { get; set; }
        public string CarotisSouffle { get; set; }
        public short? RrSys { get; set; }
        public short? RrDiast { get; set; }
        public string XRay { get; set; }
        public string StressTest { get; set; }
        public string Angio { get; set; }
        public int? Waitlist { get; set; }
        public string Diagnosis { get; set; }

        public virtual PatientDemographic Patient { get; set; }
    }
}
