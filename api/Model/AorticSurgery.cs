using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class AorticSurgery
    {
        public int ProcedureId { get; set; }
        public int? PatientId { get; set; }
        public string Aneurysm { get; set; }
        public string AneurysmType { get; set; }
        public string Dissection { get; set; }
        public string DissectionOnset { get; set; }
        public string DissectionType { get; set; }
        public string Coarctation { get; set; }
        public string OtherCongenital { get; set; }
        public string Pathology { get; set; }
        public string Indication { get; set; }
        public string OperativeTechnique { get; set; }
        public string Range { get; set; }
        public string StentGraftTechnique { get; set; }
    }
}
