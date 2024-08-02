using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/contact-types")]
    [ApiController]
    public class ContactTypeController : BaseController
    {
        private readonly IContactTypeService _contactTypeService;

        public ContactTypeController(IContactTypeService contactTypeService, IAppSession appSession) : base(appSession)
        {
            _contactTypeService = contactTypeService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertContactTypeAsync([FromBody] InsertContactTypeRequest request)
        {
            var result = await _contactTypeService.InsertContactTypeAsync(request);

            return Ok(result);
        }


        [HttpPost("get")]
        public async Task<IActionResult> GetContactTypeAsync([FromBody] GetContactTypeQuery query)
        {
            var result = await _contactTypeService.GetContactTypeAsync(query);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateContactTypeAsync([FromBody] UpdateContactTypeRequest request)
        {
            var result = await _contactTypeService.UpdateContactTypeAsync(request);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteContactTypeAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _contactTypeService.DeleteContactTypeByIdAsync(request);
            return Ok(result);
        }

        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetContactTypeByKeyAsync([FromBody] GetContactTypeByKeyQuery query)
        {
            var result = await _contactTypeService.GetContactTypeByKeyAsync(query);
            return Ok(result);
        }
    }
}