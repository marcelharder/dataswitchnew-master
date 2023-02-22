using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data.interfaces;
using api.Model.maria_models;
using dataswitch.data.interfaces;
using dataswitch.DTOs;
using dataswitch.Model;
using dataswitch.Model.maria_models;
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
        private IMariaDBStuff _maria;



        public procedureController(ecsur_kfafhContext db, IPatient pat, IMariaDBStuff maria)
        {
            _db = db;
            _pat = pat;
            _maria = maria;

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

                // add procedure to mariadb 


                // update mariadb with the newly found record_id
                // mention the correct hospital and surgeon

                // dont forget to get the euroscore
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
                if (counter < help_list.Count)
                {
                    counter = counter + 1;
                    newPatient.log_score = help_list[counter].add_score;
                }

                // now get the details from the old database




                await _maria.AddAsync(newPatient);
                await _maria.SaveAll();

                /*  // get the euroscore details i want from SQL
                 var help = new FullPatientDTO();

                 help.patientId = t;

                 // get data from the interface
                 //help = getpatientdata(t);

                 var selected_score = help_list.Where(x => x.patient_id == t).FirstOrDefault().add_score;
                 if(selected_score != null)
                 { help.log_score = selected_score;} else {help.log_score = "0";}

                 */

            }

            return Ok("hello ...");
        }



    }

    class help
    {
        public string add_score { get; set; }
        public string log_score { get; set; }
        public int procedure_id { get; set; }
        public double patient_id { get; set; }
    }








}