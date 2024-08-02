using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/cost-types")]
    [ApiController]
    public class CostTypeController : BaseController
    {
        private readonly ICostTypeService _costTypeService;

        public CostTypeController(ICostTypeService costTypeService, IAppSession appSession) : base(appSession)
        {
            _costTypeService = costTypeService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertCostTypeAsync([FromBody] InsertCostTypeRequest request)
        {
            var result = await _costTypeService.InsertCostTypeAsync(request);
            return Ok(result);
        }


        [HttpPost("get")]
        public async Task<IActionResult> GetCostTypeAsync([FromBody] GetCostTypeQuery query)
        {
            var result = await _costTypeService.GetCostTypeAsync(query);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCostTypeAsync([FromBody] UpdateCostTypeRequest request)
        {
            var result = await _costTypeService.UpdateCostTypeAsync(request);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCostTypeAsync([FromBody] DeleteTypeShortRequest request)
        {
            var result = await _costTypeService.DeleteCostTypeByIdAsync(request);
            return Ok(result);
        }

        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetCostTypeByKeyAsync([FromBody] GetCostTypeByKeyQuery query)
        {
            var result = await _costTypeService.GetCostTypeByKeyAsync(query);

            return Ok(result);
        }
    }
}
