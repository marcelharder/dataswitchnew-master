using System;
using System.Collections.Generic;

#nullable disable

namespace dataswitch.Model
{
    public partial class MinInv
    {
        public int ProcedureId { get; set; }
        public int? PatientId { get; set; }
        public int? Strategy { get; set; }
        public int? PrimaryIncision { get; set; }
        public int? PrimaryIncisionDetails { get; set; }
        public int? NumberOfIncisions { get; set; }
        public int? ConversionToStandard { get; set; }
        public int? ConversionDetails { get; set; }
        public int? Robot { get; set; }
        public int? RobotCabg { get; set; }
        public int? RobotAortic { get; set; }
        public int? RobotMitral { get; set; }
        public int? RobotTricuspid { get; set; }
        public int? RobotPulmonary { get; set; }
        public int? LimaHarvest { get; set; }
        public int? Vessel { get; set; }
        public int? Shunt { get; set; }
        public int? LadTime { get; set; }
        public int? RcaTime { get; set; }
        public int? CxTime { get; set; }
        public int? AlTime { get; set; }
        public int? Suture { get; set; }
        public int? AcuteFlow { get; set; }
        public int? AcuteFlowDetails { get; set; }
    }
}
