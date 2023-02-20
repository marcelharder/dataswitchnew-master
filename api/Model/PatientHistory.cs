﻿using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class PatientHistory
    {
        public int? PatientId { get; set; }
        public string CookieString { get; set; }
        public string RiskfactorString { get; set; }
        public double? Weight { get; set; }
        public string WeightUnits { get; set; }
        public double? Height { get; set; }
        public string HeightUnits { get; set; }
        public string RiskFactors { get; set; }
        public string RfSmoking { get; set; }
        public string RfSmokingCurrent { get; set; }
        public int? RfSmokingCurrentPk { get; set; }
        public string RfCad { get; set; }
        public string RfDiabetes { get; set; }
        public string RfDiabetesControl { get; set; }
        public string RfMorbidObesity { get; set; }
        public string RfHypercholesterolemia { get; set; }
        public int? RfHypercholesterolemiaLevel { get; set; }
        public string RfRenalFailure { get; set; }
        public string RfRenalFailLast { get; set; }
        public string RfRenalFailureDialysis { get; set; }
        public string RfHypertension { get; set; }
        public string RfCerebrovascularAccident { get; set; }
        public int? RfCerebrovascularAccidentTime { get; set; }
        public string RfInfectiousEndocarditis { get; set; }
        public int? RfInfectiousEndocardType { get; set; }
        public string RfImmunosuppressiveRx { get; set; }
        public string RfChronicLungDis { get; set; }
        public string RfPvd { get; set; }
        public string RfCvd { get; set; }
        public int? RfCvdType { get; set; }
        public string CsCardiomegaly { get; set; }
        public string CsMi { get; set; }
        public int? CsMiType { get; set; }
        public string CsMiWhen { get; set; }
        public string CsChf { get; set; }
        public string CsAngina { get; set; }
        public int? CsAnginaType { get; set; }
        public string CsAnginaUnstabType { get; set; }
        public string CsCardiogenicShock { get; set; }
        public int? CsCardioShockType { get; set; }
        public string CsResuscitation { get; set; }
        public string CsArrhythmia { get; set; }
        public int? CsArrhythmiaType { get; set; }
        public string CsArrVent { get; set; }
        public string CsArrAvBlock { get; set; }
        public string CsArrAtrialFib { get; set; }
        public string CsArrChb { get; set; }
        public string CsArrAcute { get; set; }
        public string CsArrChronic { get; set; }
        public string CsClassCcs { get; set; }
        public int? CsClassificationNyha { get; set; }
        public int? CvIntervention { get; set; }
        public DateTime? CvDate { get; set; }
        public DateTime? SurgDate { get; set; }
        public string CvOpsWithBypass { get; set; }
        public string CvOpsWithoutBypass { get; set; }
        public string CvPreviousInterval { get; set; }
        public string CvCab { get; set; }
        public string CvValve { get; set; }
        public string CvValveReplace { get; set; }
        public string CvValveReplaceA { get; set; }
        public string CvValveReplaceM { get; set; }
        public string CvValveReplaceT { get; set; }
        public string CvValveReplaceP { get; set; }
        public string CvValveRepair { get; set; }
        public string CvValveRepairA { get; set; }
        public string CvValveRepairM { get; set; }
        public string CvValveRepairT { get; set; }
        public string CvValveRepairP { get; set; }
        public string CvInvasiveCabg { get; set; }
        public string CvInvasiveValve { get; set; }
        public string CvInvasiveValveA { get; set; }
        public string CvInvasiveValveM { get; set; }
        public string CvInvasiveValveT { get; set; }
        public string CvInvasiveValveP { get; set; }
        public string CvOtherCardiac { get; set; }
        public string CvOtherCardiacLva { get; set; }
        public string CvOtherCardiacVsd { get; set; }
        public string CvOtherCardiacAsd { get; set; }
        public string CvOtherCardiacCongenital { get; set; }
        public string CvOtherCardiacTrauma { get; set; }
        public string CvOtherCardiacBatista { get; set; }
        public string CvOtherCardiacTx { get; set; }
        public string CvOtherCardiacPacemaker { get; set; }
        public string CvOtherCardiacAicd { get; set; }
        public string CvOtherCardiacOther { get; set; }
        public string CvOtherNoncardiac { get; set; }
        public string CvOtherNoncardiacAneurysm { get; set; }
        public string CvOtherNoncardiacAsc { get; set; }
        public string CvOtherNoncardiacArch { get; set; }
        public string CvOtherNoncardiacDesc { get; set; }
        public string CvOtherNoncardiacThor { get; set; }
        public string CvOtherNoncardiacAbd { get; set; }
        public string CvOtherNoncardiacEndart { get; set; }
        public string CvOtherNoncardiacOtherVasc { get; set; }
        public string CvOtherNoncardiacOtherThoracic { get; set; }
        public string CvThrombo { get; set; }
        public string CvThromboInterval { get; set; }
        public int? CvThromboAgent { get; set; }
        public string CvPtcaAther { get; set; }
        public string CvPtcaStatus { get; set; }
        public int? CvPtcaInterval { get; set; }
        public string CvPtcaSurgSameAdm { get; set; }
        public string CvPtcaNumPriorPtca { get; set; }
        public string CvNonsurg { get; set; }
        public string CvNonsurgPtca { get; set; }
        public string CvNonsurgLaser { get; set; }
        public string CvNonsurgStent { get; set; }
        public string CvNonsurgThrombolysis { get; set; }
        public string CvNonsurgBalloon { get; set; }
        public string CvNonsurgBalloonA { get; set; }
        public string CvNonsurgBalloonM { get; set; }
        public string CvNonsurgBalloonT { get; set; }
        public string CvNonsurgBalloonP { get; set; }
        public int? CvPreopMeds { get; set; }
        public int? CvPreopMedsDigitalis { get; set; }
        public int? CvPreopMedsBeta { get; set; }
        public int? CvPreopMedsCa { get; set; }
        public int? CvPreopMedsAce { get; set; }
        public int? CvPreopMedsNitratesPo { get; set; }
        public int? CvPreopMedsNitratesIv { get; set; }
        public int? CvPreopMedsAntiarrhythmics { get; set; }
        public int? CvPreopMedsAntiplatelets { get; set; }
        public int? CvPreopMedsAnticoagulants { get; set; }
        public int? CvPreopMedsDiuretics { get; set; }
        public int? CvPreopMedsInotropes { get; set; }
        public int? CvPreopMedsSteroids { get; set; }
        public int? CvPreopMedsAspirin { get; set; }
        public string DxCad { get; set; }
        public string DxCongenital { get; set; }
        public string DxValvular { get; set; }
        public string DxAortic { get; set; }
        public string DxIhss { get; set; }
        public string DxLva { get; set; }
        public double? StentIntvl { get; set; }
    }
}
