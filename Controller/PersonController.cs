using System.Threading.Tasks;
using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ICD.Base.Api.Controller
{
    [Route("api/people")]
    [ApiController]
    public class PersonController : BaseController
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService, IAppSession appSession) : base(appSession)
        {
            _personService = personService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertPersonAsync([FromBody] InsertPersonRequest request)
        {
            var result = await _personService.InsertPersonAsync(request);
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetBySpecificationAsync([FromBody] GetPeopleBySpecificationQuery query)
        {
            var result = await _personService.GetBySpecificationAsync(query);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePersonAsync([FromBody] DeleteTypeLongRequest request)
        {
            var result = await _personService.DeleteByIdAsync(request);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdatePersonRequest request)
        {
            var result = await _personService.UpdatePersonAsync(request);
            return Ok(result);
        }
        
        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetPeopleByKeyAsync([FromBody] GetPeopleByKeyQuery query)
        {
            var result = await _personService.GetPeopleByKeyAsync(query);
            return Ok(result);
        }
    }
}