using api.Model.maria_models;
using AutoMapper;
using dataswitch.DTOs;

namespace api.code
{
public class specialMaps 
{
    IMapper _map;
    public specialMaps(IMapper map)
    {
        _map=map;
    }
    public void getPatientData(){
     
    }

    public ProcedureDTO mapToProcedureDTO(Class_Procedure p)
        {
            return _map.Map<Class_Procedure, ProcedureDTO>(p);
        }

   

    public void getAorticSurgeryData(){

    }
    public void getCABGData(){

    }
    public void getCPBData(){

    }
    public void getMinInvData(){

    }













}
}