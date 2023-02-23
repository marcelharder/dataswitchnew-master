using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model.maria_models;

namespace api.data.interfaces
{
    public interface IProcedure
    {
        Task<Class_Procedure> getSpecificProcedure(int id);
        Task<int> AddAsync(Class_Procedure p); 
        Task<int> UpdateAsync(Class_Procedure p); 
        Task<int> DeleteAsync(Class_Procedure p);
        Task<bool> SaveAll();
    }
}