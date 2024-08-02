using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/person-identities")]
    [ApiController]
    public class PersonIdentityController : BaseController
    {
        private readonly IPersonIdentityService _personIdentityService;

        public PersonIdentityController(IPersonIdentityService personIdentityService, IAppSession appSession) : base(appSession)
        {
            _personIdentityService = personIdentityService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertPersonIdentityAsync([FromBody] InsertPersonIdentityRequest request)
        {
            var result = await _personIdentityService.InsertPersonIdentityAsync(request);
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetPersonIdentityByPersonRefAsync([FromBody] GetPersonIdentityQuery query)
        {
            var result = await _personIdentityService.GetPersonIdentityByPersonRefAsync(query);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeletePersonIdentityByIdAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _personIdentityService.DeletePersonIdentityByIdAsync(request);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdatePersonIdentityByIdAsync([FromBody] UpdatePersonIdentityRequest request)
        {
            var result = await _personIdentityService.UpdatePersonIdentityByIdAsync(request);
            return Ok(result);
        }
    }
}