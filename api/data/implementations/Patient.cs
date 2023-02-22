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
        public async Task<Class_Patient> getSpecificPatient(int id)
        {
            var result = await _db.Patients.FirstOrDefaultAsync(x => x.PatientId == id);
            return result;
        }
    }
}