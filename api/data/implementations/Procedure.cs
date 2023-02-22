using System.Threading.Tasks;
using api.Model.maria_models;
using dataswitch.Model.maria_models;
using Microsoft.EntityFrameworkCore;

namespace api.data.implementations
{
    public class Procedure : interfaces.IProcedure
    {
        private MariaContext _maria;
        public Procedure(MariaContext maria)
        {
            _maria = maria;
        }
        public async Task<int> AddAsync(Class_Procedure p)
        {
            _maria.Add(p);
            if(await SaveAll()){return 1;}else {return 0;}
        }

        public Task<int> DeleteAsync(Class_Procedure p)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Class_Procedure> getSpecificProcedure(int id)
        {
            return await _maria.Procedures.FirstOrDefaultAsync(x => x.ProcedureId == id);
        }

        public async Task<bool> SaveAll()
        {
           return await _maria.SaveChangesAsync() > 0;
        }

        public Task<int> UpdateAsync(Class_Procedure p)
        {
            throw new System.NotImplementedException();
        }
    }
}