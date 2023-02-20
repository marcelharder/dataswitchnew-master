using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class Cpb
    {
        public int ProcedureId { get; set; }
        public int? PatientId { get; set; }
        public int? CrossClampTime { get; set; }
        public int? PerfusionTime { get; set; }
        public int? LowestCoreTemp { get; set; }
        public string Cardioplegia { get; set; }
        public string CardioplegiaBlood { get; set; }
        public string CardioplegiaCrystalloid { get; set; }
        public string CardioplegiaO2Crystalloid { get; set; }
        public int? InfusionModeAnte { get; set; }
        public int? InfusionModeRetro { get; set; }
        public int? InfusionDoseInt { get; set; }
        public int? InfusionDoseCont { get; set; }
        public int? CardioplegiaTempWarm { get; set; }
        public int? CardioplegiaTempCold { get; set; }
        public string Iabp { get; set; }
        public int? IabpOptions { get; set; }
        public int? IabpInd { get; set; }
        public int? PacingHarv { get; set; }
        public int? PacingAtrial { get; set; }
        public int? PacingVentricular { get; set; }
        public int? Cardioversion { get; set; }
        public string Vad { get; set; }
        public int? Lvad { get; set; }
        public int? Rvad { get; set; }
        public string Bvad { get; set; }
        public string Tah { get; set; }
        public int? Inotropes { get; set; }
        public int? Antiarrhythmics { get; set; }
        public int? SkinIncisionStartTime { get; set; }
        public int? SkinIncisionStopTime { get; set; }
    }
}
