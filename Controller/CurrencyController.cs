using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/currencies")]
    [ApiController]
    public class CurrencyController : BaseController
    {
        private readonly ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService, IAppSession appSession) : base(appSession)
        {
            _currencyService = currencyService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertCurrencyAsync([FromBody] InsertCurrencyRequest request)
        {
            var result = await _currencyService.InsertCurrencyAsync(request);
            return Ok(result);
        }


        [HttpPost("get")]
        public async Task<IActionResult> GetCurrencyAsync([FromBody] GetCurrencyQuery query)
        {
            var result = await _currencyService.GetCurrencyAsync(query);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCurrencyAsync([FromBody] UpdateCurrencyRequest request)
        {
            var result = await _currencyService.UpdateCurrencyAsync(request);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCurrencyAsync([FromBody] DeleteTypeByteRequest request)
        {
            var result = await _currencyService.DeleteCurrencyByIdAsync(request);
            return Ok(result);
        }

        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetCurrencyByKeyAsync([FromBody] GetCurrencyByKeyQuery query)
        {
            var result = await _currencyService.GetCurrencyByKeyAsync(query);

            return Ok(result);
        }
    }
}
