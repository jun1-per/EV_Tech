using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/cost-type-taxes")]
    [ApiController]
    public class CostTypeTaxController : BaseController
    {
        private readonly ICostTypeTaxService _costTypeTaxService;

        public CostTypeTaxController(ICostTypeTaxService costTypeTaxService, IAppSession appSession) : base(appSession)
        {
            _costTypeTaxService = costTypeTaxService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertCostTypeTaxAsync([FromBody] InsertCostTypeTaxRequest request)
        {
            var res = await _costTypeTaxService.InsertCostTypeTaxAsync(request);

            return Ok(res);
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetCostTypeTaxAsync([FromBody] GetCostTypeTaxQuery query)
        {
            var res = await _costTypeTaxService.GetCostTypeTaxAsync(query);

            return Ok(res);
        }
    }
}
