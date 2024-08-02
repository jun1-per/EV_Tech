using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/countries")]
    [ApiController]
    public class CountryController : BaseController
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService, IAppSession appSession) : base(appSession)
        {
            _countryService = countryService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertCountryAsync([FromBody] InsertCountryRequest request)
        {
            var result = await _countryService.InsertCountryAsync(request);
            return Ok(result);
        }
        
        [HttpPost("get")]
        public async Task<IActionResult> GetCountryAsync([FromBody] GetCountryQuery query)
        {
            var result = await _countryService.GetCountryAsync(query);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCountryAsync([FromBody] UpdateCountryRequest request)
        {
            var result = await _countryService.UpdateCountryAsync(request);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCountryAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _countryService.DeleteCountryByIdAsync(request);
            return Ok(result);
        }
        
        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetCountryByKeyAsync([FromBody] GetCountrybyKeyQuery query)
        {
            var result = await _countryService.GetCountryByKeyAsync(query);
            return Ok(result);
        }
    }
}
