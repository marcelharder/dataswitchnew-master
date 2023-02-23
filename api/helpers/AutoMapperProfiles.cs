using api.DTOs;
using api.Model.maria_models;
using AutoMapper;
using dataswitch.DTOs;

namespace api.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
             CreateMap<Class_Patient, FullPatientDTO>();
            
            CreateMap<FullPatientDTO, Class_Patient>()
            .ForMember(dest => dest.PatientId, opt => opt.Ignore())
            .ForMember(dest => dest.extra_cardiac_arteriopathy, opt => opt.NullSubstitute("0"))
            .ForMember(dest => dest.previous_cardiac_surgery, opt => opt.NullSubstitute("0"))
            .ForMember(dest => dest.IsPreviousIntervention, opt => opt.NullSubstitute("0"))
            .ForMember(dest => dest.copd, opt => opt.NullSubstitute("0"))
            .ForMember(dest => dest.active_endocarditis, opt => opt.NullSubstitute("0"))
            .ForMember(dest => dest.CCS, opt => opt.NullSubstitute("0"))
            .ForMember(dest => dest.LVEF, opt => opt.NullSubstitute("0"))
            .ForMember(dest => dest.recent_mi, opt => opt.NullSubstitute("0"))
            .ForMember(dest => dest.NOPM, opt => opt.NullSubstitute("0"))
            .ForMember(dest => dest.surgery_on_thoracic_aorta, opt => opt.NullSubstitute("0")); 


            CreateMap<Class_Procedure, ProcedureDTO>();

            
            CreateMap<ProcedureDTO, Class_Procedure>()
            .ForMember(dest => dest.Sequence, opt => opt.Ignore());

          /*   CreateMap<Class_Patient, PatientForReturnDTO>();


            CreateMap<Class_Procedure, ProcedureListDTO>();
            CreateMap<Class_Procedure, ProcedureDTO>();


            CreateMap<ProcedureDTO, Class_Procedure>()
            .ForMember(dest => dest.Sequence, opt => opt.Ignore());



           
            CreateMap<Class_Valve, ValveForReturnDTO>();
            CreateMap<ValveForReturnDTO, Class_Valve>().ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<PreviewForReturnDTO, Class_Preview_Operative_report>().ForMember(dest => dest.Id, opt => opt.Ignore());
            CreateMap<PreviewForReturnDTO, Class_privacy_model>();

            CreateMap<Class_minInv, MinInvForReturn>();
            CreateMap<MinInvForReturn, Class_minInv>().ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Class_Ref_Phys, refphysForReturn>();
            CreateMap<refphysForUpdate, Class_Ref_Phys>().ForMember(dest => dest.Id, opt => opt.Ignore()); */

          
        }
    }
}