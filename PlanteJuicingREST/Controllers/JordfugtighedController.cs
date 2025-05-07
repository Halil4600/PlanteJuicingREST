using Microsoft.AspNetCore.Mvc;
using PlanteJuicingREST.Interface;
using PlanteJuicingREST.Models;
using PlanteJuicingREST.Repositories;
using PlanteJuicingREST.Records;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlanteJuicingREST.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JordfugtighedController : ControllerBase
    {
        private readonly IJordfugtighedRepository _jordfugtighedRepository;
        public JordfugtighedController(IJordfugtighedRepository jordfugtighedRepository)
        {
            _jordfugtighedRepository = jordfugtighedRepository;
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // GET: api/<JordfugtighedController> get metoden neden under linje 34 til 43 
        [HttpGet]
        public ActionResult <IEnumerable<Jordfugtighed>> Get()
        {
            IEnumerable<Jordfugtighed> result = _jordfugtighedRepository.GetAllJordfugtighed();
            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound("No jordfugtighed found");

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        

        

        // POST api/<JordfugtighedController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<Jordfugtighed> Post([FromBody]JordFugtighedsRecord newjordFugtighedsRecord)
        {
            try
            {

                Jordfugtighed jordfugtighedConverted = RecordHelper.ConvertJordFugtighedRecord(newjordFugtighedsRecord);
                Jordfugtighed jordfugtighed = _jordfugtighedRepository.Add(jordfugtighedConverted);
                return Created("**" + jordfugtighedConverted.Id, jordfugtighed);



            }
            
            catch (ArgumentNullException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return BadRequest(ex.Message);
            }

           
        
        }
    }
}
