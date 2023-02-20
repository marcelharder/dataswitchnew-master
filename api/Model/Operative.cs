using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class Operative
    {
        public int? ProcedureId { get; set; }
        public int? PatientId { get; set; }
        public string SurgeonName { get; set; }
        public string SurgeonGroup { get; set; }
        public string AssistantSurgeon { get; set; }
        public string AssNo2 { get; set; }
        public string Resident { get; set; }
        public string ResponsibleForProc { get; set; }
        public int? ClassificationAsa { get; set; }
        public int? ReopReason { get; set; }
        public string FdStatus { get; set; }
        public int? StatusUrgent { get; set; }
        public int? StatusEmergent { get; set; }
        public int? OpCategory { get; set; }
        public int? PredRiskOfMortality { get; set; }
        public int? MinimallyInvasiveProcedure { get; set; }
        public int? PrimIndMinInvas { get; set; }
        public int? PrimaryIncision { get; set; }
        public int? TotalIncisionNumber { get; set; }
        public string ConversionToStandardIncision { get; set; }
        public int? IndCon { get; set; }
        public int? CardiopulmonaryBypass { get; set; }
        public int? AorticOcclusion { get; set; }
        public int? CannulationMethod { get; set; }
        public int? IntracoronaryShunt { get; set; }
        public string IschemicTimeLad { get; set; }
        public string IschemicTimeRca { get; set; }
        public string IschemicTimeCfx { get; set; }
        public int? SutureTechnique { get; set; }
        public int? VesselStabilization { get; set; }
        public int? ImaHarvestTech { get; set; }
        public int? FlowCheck { get; set; }
        public string OtherCard { get; set; }
        public string OtherCardiacLva { get; set; }
        public string OtherCardiacVsd { get; set; }
        public string OtherCardiacAsd { get; set; }
        public string OtherCardiacBatista { get; set; }
        public string OtherCardiacCongenital { get; set; }
        public string OtherCardiacLaser { get; set; }
        public string OtherCardiacTrauma { get; set; }
        public string OtherCardiacTx { get; set; }
        public string OtherCardiacPacemaker { get; set; }
        public string OtherCardiacAicd { get; set; }
        public string OtherCardiacOther { get; set; }
        public string OtherNoncard { get; set; }
        public string OtherNoncardiacAorticAneurysm { get; set; }
        public string OtherNoncardiacAsc { get; set; }
        public string OtherNoncardiacArch { get; set; }
        public string OtherNoncardiacDesc { get; set; }
        public string OtherNoncardiacThor { get; set; }
        public string OtherNoncardiacAbd { get; set; }
        public string OtherNoncardiacCarotidEndarterectomy { get; set; }
        public string OtherNoncardiacVascular { get; set; }
        public string OtherNoncardiacThoracic { get; set; }
        public int? ConversionToCpb { get; set; }
        public string SurgVentricularRestoration { get; set; }
        public int? PredictedDeepSternalWondInfx { get; set; }
        public int? PredictedReoperation { get; set; }
        public int? PredictedPermanentStroke { get; set; }
        public int? PredictedProlongedVentilation { get; set; }
        public int? PredictedRenalFailure { get; set; }
        public int? PredictedMorbidityOrMortality { get; set; }
        public int? PredictedShortLenStay { get; set; }
        public int? PredictedLongLenStay { get; set; }
    }
}
