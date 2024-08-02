using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/person-titles")]
    [ApiController]
    public class PersonTitleController : BaseController
    {
        private readonly IPersonTitleService _personTitleService;

        public PersonTitleController(IPersonTitleService personTitleService, IAppSession appSession) : base(appSession)
        {
            _personTitleService = personTitleService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> CreatePersonTitleAsync([FromBody] InsertPersonTitleRequest request)
        {
            var result = await _personTitleService.InsertPersonTitleAsync(request);
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetActivePeopleTitleByLanguageRef([FromBody] GetPersonTitlesQuery query)
        {

            var result = await _personTitleService.GetPersonTitlesByLanguageRefAsync(query);
            return Ok(result);
        }

        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetPersonTitleByKeyAsync([FromBody] GetPersonTitleByKeyQuery query)
        {
            var result = await _personTitleService.GetPersonTitleByKeyAsync(query);

            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePersonTitleByIdAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _personTitleService.DeletePersonTitleByIdAsync(request);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePersonTitleByIdAsync([FromBody] UpdatePersonTitleRequest request)
        {
            var result = await _personTitleService.UpdatePersonTitleByIdAsync(request);
            return Ok(result);
        }

        //[HttpPost("test-get-proc")]
        //public IActionResult TestGetPersonProc()
        //{
        //    var result = _personTitleService.TestGetPersonProc();
        //    return Ok(result);
        //}
    }
}