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
    public class WaterLevelController : ControllerBase
    {


        private readonly IWaterLevelRepository _waterLevelRepository;
        public WaterLevelController(IWaterLevelRepository waterLevelRepository)
        {
            _waterLevelRepository = waterLevelRepository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // GET: api/<WaterLevelController>
        [HttpGet]
        public ActionResult<IEnumerable<WaterLevelModel>> Get()
        {
            IEnumerable<WaterLevelModel> result = _waterLevelRepository.GetAllWaterLevel();
            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound("No water level found");
        }

        // POST api/<WaterLevelController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]


        public ActionResult<WaterLevelModel> Post([FromBody] WaterLevelRecord newwaterLevelModelRecord)
        {
            try
            {
                WaterLevelModel waterLevelModelConverted = RecordHelperWaterLevel.ConvertWaterLevelRecords(newwaterLevelModelRecord);
                WaterLevelModel waterLevelModel = _waterLevelRepository.Add(waterLevelModelConverted);
                return Created("**" + waterLevelModelConverted.Id, waterLevelModel);

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
