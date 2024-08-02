using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/person-contacts")]
    [ApiController]
    public class PersonContactController : BaseController
    {
        private readonly IPersonContactService _personContactService;

        public PersonContactController(IPersonContactService personContactService, IAppSession appSession) : base(appSession)
        {
            _personContactService = personContactService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertPersonContactAsync([FromBody] InsertPersonContactRequest request)
        {
            var result = await _personContactService.InsertPersonContactAsync(request);
            return Ok(result);
        }


        [HttpPost("get")]
        public async Task<IActionResult> GetPersonContactAsync([FromBody] GetPersonContactQuery query)
        {
            var result = await _personContactService.GetPersonContactAsync(query);
            return Ok(result);
        }
    }
}