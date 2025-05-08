
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
    public class TempController : ControllerBase
    {
        private readonly ITempRepository _tempRepository;
        public TempController(ITempRepository tempRepository)
        {
            _tempRepository = tempRepository;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // GET: api/<TempController>
        [HttpGet]

        public ActionResult<IEnumerable<TempModel>> Get()
        {
            IEnumerable<TempModel> result = _tempRepository.GetAllTemp();
            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound("No temperature found");
        }


        // POST api/<TempController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]


        public ActionResult<TempModel> Post([FromBody] TempRecords newtempModelRecord)
        {
            try
            {
                TempModel tempModelConverted = RecordHelperTemp.ConvertTempRecords(newtempModelRecord);
                TempModel tempModel = _tempRepository.Add(tempModelConverted);
                return Created("**" + tempModelConverted.Id, tempModel);



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
