using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class UpdateToMariaDBController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var result = "Gelukt";
            return result;
        }
    }
    