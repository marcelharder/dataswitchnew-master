using System;

namespace dataswitch.DTOs
{

    public class procedureForReturnDTO{
        public int procedure_id {get; set;}
        public DateTime? surgeryDate {get; set;}
        public string surgeonName {get; set;}
        public string description {get; set;}
    }
}