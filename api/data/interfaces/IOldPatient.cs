using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dataswitch.Model;

namespace api.data.interfaces
{
    public interface IOldPatient
    {
        Task<PatientDemographic> getSpecificPatientDemographic(int id);
        Task<PatientHistory> getSpecificPatientHistory(int id);
    }
}