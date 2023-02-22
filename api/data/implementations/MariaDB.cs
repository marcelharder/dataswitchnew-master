using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model.maria_models;
using dataswitch.data.interfaces;
using dataswitch.Model.maria_models;

namespace api.data.implementations
{
    public class MariaDB : IMariaDBStuff
    {
        private MariaContext _context;
        

        public MariaDB(MariaContext context) 
        {
            _context = context;
        }
               

        public async Task<int> AddAsync(Class_Patient help)
        {
            _context.Patients.Add(help);
            if(await SaveAll()){return 1;}else {return 0;};
        }

        public Task<int> DeleteAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0; 
        }

        public Task<int> UpdateAsync<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}