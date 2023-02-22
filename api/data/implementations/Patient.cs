using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data.interfaces;
using api.Model.maria_models;
using dataswitch.Model.maria_models;
using Microsoft.EntityFrameworkCore;

namespace api.data.implementations
{
    public class Patient : IPatient
    {
        private MariaContext _db;
        public Patient(MariaContext db)
        {
            _db = db;
        }

        public async Task<int> AddAsync(Class_Patient p)
        {
            _db.Add(p);
            if(await SaveAll()){return 1;}else {return 0;}
        }

        public Task<int> DeleteAsync(Class_Patient p)
        {
            throw new NotImplementedException();
        }

        public async Task<Class_Patient> getSpecificPatient(int id)
        {
            var result = await _db.Patients.FirstOrDefaultAsync(x => x.PatientId == id);
            return result;
        }

        public async Task<bool> SaveAll()
        {
           return await _db.SaveChangesAsync() > 0;
        }

        public Task<int> UpdateAsync(Class_Patient p)
        {
            throw new NotImplementedException();
        }
    }
}