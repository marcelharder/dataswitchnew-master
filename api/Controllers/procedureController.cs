using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.code;
using api.data.interfaces;
using api.Model.maria_models;
using dataswitch.DTOs;
using dataswitch.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dataswitch.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class procedureController : ControllerBase
    {
        private ecsur_kfafhContext _db;
        private IPatient _pat;
        private IProcedure _proc;
        private specialMaps _sp;





        public procedureController(
        ecsur_kfafhContext db,
        IPatient pat,
        IProcedure proc,
        specialMaps sp)
        {
            _db = db;
            _pat = pat;
            _sp = sp;
            _proc = proc;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = new List<procedureListDto>();
            var patients = new List<double>();
            var procedures = new List<int>();
            var help_list = new List<help>();

            using (var command = _db.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText =
                 " SELECT procedure_info.record_id, procedure_info.patient_id, procedure_info.fd_TYPE, operative.SURGEON_NAME, procedure_info.SURGERY_DATE," +
                 " procedure_info.PROCEDURE_ID FROM procedure_info,operative where procedure_info.PROCEDURE_ID = " +
                 " operative.PROCEDURE_ID AND operative.SURGEON_NAME = 'M.P. Harder'";
                _db.Database.OpenConnection();
                using (var q = command.ExecuteReader())
                {
                    while (q.Read())
                    {
                        procedureListDto pl = new procedureListDto();
                        pl.fd_Type = q.GetInt16(0);
                        pl.completed = "n/a";
                        pl.patientId = q.GetDouble(1);
                        patients.Add(pl.patientId);
                        pl.description = q.GetString(2);
                        pl.dateOfSurgery = q.GetDateTime(4);
                        pl.procedureId = q.GetInt32(5);
                        procedures.Add(pl.procedureId);
                        result.Add(pl);
                    }
                }
                _db.Database.CloseConnection();

                command.CommandText =
                "select eu.add_score,eu.log_score,pro.procedure_id,pro.PATIENT_ID " +
                "from euroscore eu inner join procedure_info pro " +
                "on eu.procedure_id = pro.PROCEDURE_ID inner join operative op on " +
                "op.PROCEDURE_ID = pro.PROCEDURE_ID " +
                "where op.SURGEON_NAME = 'M.P. Harder'";

                _db.Database.OpenConnection();
                using (var r = command.ExecuteReader())
                {
                    while (r.Read())
                    {
                        var h = new help();
                        h.add_score = r.GetString(0);
                        h.procedure_id = r.GetInt32(2);
                        h.patient_id = r.GetDouble(3);

                        help_list.Add(h);
                    }
                }
                _db.Database.CloseConnection();
            }



            foreach (procedureListDto td in result)
            {

                var newProcedure = new Class_Procedure();
                newProcedure.ProcedureId = td.procedureId;
                newProcedure.PatientId = (int)td.patientId;
                newProcedure.fdType = td.fd_Type;
                newProcedure.Description = td.description;
                newProcedure.DateOfSurgery = td.dateOfSurgery;
                newProcedure.SelectedSurgeon = 5; // is de code voor m.p. harder
                newProcedure.hospital = 31; // code voor hospital is kfafh

                // get the rest of the data 
                var extra = new ProcedureDTO();
                // var oldProcedure = getOldProcedure(td.procedureId);
                extra = getOldProcedure(td.procedureId);

                newProcedure.Comment1 = extra.comment1;
                newProcedure.Comment2 = extra.comment2;
                newProcedure.Comment3 = extra.comment2;


                // save to the database
                await _proc.AddAsync(newProcedure);
                await _proc.SaveAll();

            }
            // delete double values in patientList
            var nodoubleList = new List<double>();
            nodoubleList = patients.Distinct().ToList();

            var counter = 0;

            foreach (double t in nodoubleList)
            {
                var newPatient = new Class_Patient();
                newPatient.PatientId = Convert.ToInt32(t);
                // get the log_score now
                if (counter < help_list.Count - 1) { counter = counter + 1; newPatient.log_score = help_list[counter].add_score; }
                // get the rest of the details





                await _pat.AddAsync(newPatient);
                await _pat.SaveAll();
            }

            return Ok("hello ...");
        }

        private ProcedureDTO getOldProcedure(int procedureId)
        {
            var result = new ProcedureDTO();
            using (var command = _db.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText =
                 " SELECT procedure_info.record_id, procedure_info.patient_id, procedure_info.fd_TYPE, operative.SURGEON_NAME, procedure_info.SURGERY_DATE," +
                 " procedure_info.PROCEDURE_ID FROM procedure_info,operative where procedure_info.PROCEDURE_ID = " +
                 " operative.PROCEDURE_ID AND operative.SURGEON_NAME = 'M.P. Harder'";
                _db.Database.OpenConnection();
                using (var q = command.ExecuteReader())
                {
                    while (q.Read())
                    {

                    }
                }
                _db.Database.CloseConnection();
            }
            return result;
        }

        class help
        {
            public string add_score { get; set; }
            public string log_score { get; set; }
            public int procedure_id { get; set; }
            public double patient_id { get; set; }
        }






    }

}