using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public procedureController(ecsur_kfafhContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = new List<procedureListDto>();
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
                        pl.description = q.GetString(2);
                        pl.dateOfSurgery =  q.GetDateTime(4);
                        pl.procedureId = q.GetInt32(5);
                        result.Add(pl);
                    }
                }
            }
            return Ok(result);
        }
    }
}