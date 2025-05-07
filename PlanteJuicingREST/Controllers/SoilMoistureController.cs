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
    public class SoilMoistureController : ControllerBase
    {
        private readonly ISoilMoistureRepository _soilMoistureRepository;
        public SoilMoistureController(ISoilMoistureRepository soilMoistureRepository)
        {
            _soilMoistureRepository = soilMoistureRepository;
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // GET: api/<JordfugtighedController> get metoden neden under linje 34 til 43 
        [HttpGet]
        public ActionResult <IEnumerable<SoilMoistureModel>> Get()
        {
            IEnumerable<SoilMoistureModel> result = _soilMoistureRepository.GetAllSoilMoisture();
            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound("No soil moisture found");

        }
        
        // POST api/<JordfugtighedController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public ActionResult<SoilMoistureModel> Post([FromBody] SoilMoistureRecord newSoilMoistureRecord)
        {
            try
            {

                SoilMoistureModel soilMoistureModelConverted = RecordHelper.ConvertSoilMoistureRecord(newSoilMoistureRecord);
                SoilMoistureModel soilMoistureModel = _soilMoistureRepository.Add(soilMoistureModelConverted);
                return Created("**" + soilMoistureModelConverted.Id, soilMoistureModel);
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
