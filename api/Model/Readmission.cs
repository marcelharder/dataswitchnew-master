using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class Readmission
    {
        public int PatientId { get; set; }
        public string Anticoagulant { get; set; }
        public string Tamponade { get; set; }
        public string Mi { get; set; }
        public string Bleeding { get; set; }
        public string Graft { get; set; }
        public string Cath { get; set; }
        public string CathPtca { get; set; }
        public string CathStent { get; set; }
        public string Valve { get; set; }
        public string Chf { get; set; }
        public string RenalFailure { get; set; }
        public string Pneumonia { get; set; }
        public string Cva { get; set; }
        public string Tia { get; set; }
        public string Vascular { get; set; }
        public string SternalInfect { get; set; }
        public string LegInfect { get; set; }
        public string Arrhythmia { get; set; }
        public string HeartBlock { get; set; }
        public string Ppm { get; set; }
        public string Other { get; set; }
        public string OtherSpecify { get; set; }
    }
}
