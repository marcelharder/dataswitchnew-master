using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class EusurPostop
    {
        public int ProcedureId { get; set; }
        public int? PatientId { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? ExtubationDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public DateTime? Arrival1Date { get; set; }
        public DateTime? Extubation1Date { get; set; }
        public DateTime? Discharge1Date { get; set; }
        public DateTime? ReintubationDate { get; set; }
        public int? ReintubationMin { get; set; }
        public int? ReintubationHr { get; set; }
        public int? ArrTimeHr { get; set; }
        public int? ArrTimeMin { get; set; }
        public int? ExtTimeHr { get; set; }
        public int? ExtTimeMin { get; set; }
        public int? DischargeTimeHr { get; set; }
        public int? DischargeTimeMin { get; set; }
        public int? Arr1Min { get; set; }
        public int? Arr1Hr { get; set; }
        public int? Dis1Hr { get; set; }
        public int? Dis1Min { get; set; }
        public int? Ext1Hr { get; set; }
        public int? Ext1Min { get; set; }
        public string IcuStay1 { get; set; }
        public string IcuStay2 { get; set; }
        public string IcuStay3 { get; set; }
        public string VentStay1 { get; set; }
        public string VentStay2 { get; set; }
        public string VentStay3 { get; set; }
        public string BloodProducts { get; set; }
        public string AutologousBlood { get; set; }
        public int? Pc { get; set; }
        public int? Ffp { get; set; }
        public int? Platelets { get; set; }
        public string WhenUsed { get; set; }
        public string SternalDehis { get; set; }
        public string Paraplegie { get; set; }
        public string ReopSternalDehis { get; set; }
        public string ReopResuture { get; set; }
        public string Lowcardiacoutput { get; set; }
        public string Inotropes { get; set; }
        public string Iabp { get; set; }
        public string Vads { get; set; }
        public string Svt { get; set; }
        public string Tv { get; set; }
        public string PermanentPm { get; set; }
        public string GiHemorrhage { get; set; }
        public string GiMesenteric { get; set; }
        public string GiChole { get; set; }
        public string GiIleus { get; set; }
        public string Arrythmia { get; set; }
        public string OtherCauseDeath { get; set; }
        public string ActivitiesDischarge { get; set; }
        public string SentTo { get; set; }
        public string MortalityDateString { get; set; }
        public string HighestCreatinine { get; set; }
        public string Readmitted { get; set; }
        public string Reintubated { get; set; }
        public short? OverledenNaDezeOperatie { get; set; }
    }
}
