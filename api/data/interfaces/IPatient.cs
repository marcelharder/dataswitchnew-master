using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model.maria_models;

namespace api.data.interfaces
{
    public interface IPatient
    {
        Task<Class_Patient> getSpecificPatient(int id);
        Task<int> AddAsync(Class_Patient p); 
        Task<int> UpdateAsync(Class_Patient p); 
        Task<int> DeleteAsync(Class_Patient p);
        Task<bool> SaveAll();
    }
}