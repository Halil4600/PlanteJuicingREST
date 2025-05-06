using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlanteJuicingREST.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JordfugtighedController : ControllerBase
    {

        // GET: api/<JordfugtighedController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<JordfugtighedController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JordfugtighedController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JordfugtighedController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JordfugtighedController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
