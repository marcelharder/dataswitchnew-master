using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class PostOp
    {
        public int ProcedureId { get; set; }
        public int? PatientId { get; set; }
        public int? Drg { get; set; }
        public int? PostOpVentHrs { get; set; }
        public string BbpUsed { get; set; }
        public string BbpRbc { get; set; }
        public string BbpFfp { get; set; }
        public string BbpCryo { get; set; }
        public string BbpPlatelets { get; set; }
        public string PostOpStudy { get; set; }
        public string PostOpAngio { get; set; }
        public string PostOpDbStress { get; set; }
        public string PostOpTee { get; set; }
        public string PostOpDoppler { get; set; }
        public string PostOpOther { get; set; }
        public string PostOpOtherDesc { get; set; }
        public string GraftStenOcc { get; set; }
        public string PtcaBalloon { get; set; }
        public string PtcaLaser { get; set; }
        public string PtcaStent { get; set; }
        public string PtcaAtherectomy { get; set; }
        public string Complications { get; set; }
        public string Operative { get; set; }
        public string ReopBleeding { get; set; }
        public string ReopValveDysfunction { get; set; }
        public string ReopGraftOcclusion { get; set; }
        public string ReopOtherCardiac { get; set; }
        public string ReopOtherNoncardiac { get; set; }
        public string PerioperativeMi { get; set; }
        public string Infection { get; set; }
        public string SternumSuperficial { get; set; }
        public string SternumDeep { get; set; }
        public string Thoracotomy { get; set; }
        public string Leg { get; set; }
        public string IabpSite { get; set; }
        public string Septicemia { get; set; }
        public string Uti { get; set; }
        public string PortSite { get; set; }
        public string Neurologic { get; set; }
        public string StrokePermanent { get; set; }
        public string StrokeTransient { get; set; }
        public string Delirium { get; set; }
        public string ContinuousComa { get; set; }
        public string Pulmonary { get; set; }
        public string VentilatorProlonged { get; set; }
        public int? VentilatorDays { get; set; }
        public string PulmonaryEmbolism { get; set; }
        public string PulmonaryEdema { get; set; }
        public string Ards { get; set; }
        public string Pneumonia { get; set; }
        public string Renal { get; set; }
        public string RenalFailure { get; set; }
        public string DialysisRequired { get; set; }
        public string Valvular { get; set; }
        public string StructuralDeterioration { get; set; }
        public string NonstructuralDeterioration { get; set; }
        public string Thromboembolism { get; set; }
        public string ValveThrombus { get; set; }
        public string AnticoagulantComplication { get; set; }
        public string ProsthValveEndocarditis { get; set; }
        public string Vascular { get; set; }
        public string AorticDissection { get; set; }
        public string IliacFemDissection { get; set; }
        public string AcuteLimbIschemia { get; set; }
        public string OtherComps { get; set; }
        public string OtherHeartBlock { get; set; }
        public string OtherCardiacArrest { get; set; }
        public string OtherAnticoagulantComplication { get; set; }
        public string OtherTamponade { get; set; }
        public string OtherGiComplications { get; set; }
        public string OtherMultiSystemFailure { get; set; }
        public string OtherAfib { get; set; }
        public string OtherOther { get; set; }
        public int? Mortality { get; set; }
        public int? MortalityDiscStatus { get; set; }
        public int? Mortality30Day { get; set; }
        public DateTime? MortalityDate { get; set; }
        public int? MortalityLocation { get; set; }
        public int? OperativeMortality { get; set; }
        public int? MortPrimCause { get; set; }
        public int? Readmission { get; set; }
        public int? ReadmitReasonHarv { get; set; }
        public int? InitialIcuHours { get; set; }
        public int? ReadmissionToIcu { get; set; }
        public int? AdditionalIcuHours { get; set; }
        public int? TotalHrsIcu { get; set; }
        public int? InitialHoursVentilated { get; set; }
        public int? ReintubatedDuringStay { get; set; }
        public int? AdditionalHoursVentilated { get; set; }
    }
}
