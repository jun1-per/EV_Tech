using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/tax")]
    [ApiController]
    public class TaxController : BaseController
    {
        private readonly ITaxService _taxService;

        public TaxController(ITaxService taxService, IAppSession appSession) : base(appSession)
        {
            _taxService = taxService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertTaxAsync([FromBody] InsertTaxRequest request)
        {
            var result = await _taxService.InsertTaxAsync(request);
            return Ok(result);
        }

        [HttpPost("insert-by-tablename")]
        public async Task<IActionResult> InsertTaxByTableNameAsync([FromBody] InsertTaxByTableNameRequest request)
        {
            var result = await _taxService.InsertTaxByTableNameAsync(request);
            return Ok(result);
        }

        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetTaxByKeyAsync([FromBody] GetTaxByKeyQuery query)
        {
            var result = await _taxService.GetTaxByKeyAsync(query);
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetTaxAsync([FromBody] GetTaxQuery query)
        {
            var result = await _taxService.GetTaxAsync(query);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateTaxAsync([FromBody] UpdateTaxRequest request)
        {
            var result = await _taxService.UpdateTaxAsync(request);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteTaxAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _taxService.DeleteTaxByIdAsync(request);
            return Ok(result);
        }

    }
}
