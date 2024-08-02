using ICD.Base.BusinessService;
using ICD.Base.BusinessServiceContract;
using ICD.Base.RepositoryContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/Cities")]
    [ApiController]
    public class CityController : BaseController
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService, IAppSession appSession) : base(appSession)
        {
            _cityService = cityService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertCityAsync([FromBody] InsertCityRequest request)
        {
            var result = await _cityService.InsertCityAsync(request);

            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateCityAsync([FromBody] UpdateCityRequest request)
        {
            var result = await _cityService.UpdateCityAsync(request);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteCityAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _cityService.DeleteCityAsync(request);
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetCityAsync([FromBody] GetCityQuery query)
        {
            var result = await _cityService.GetCityAsync(query);
            return Ok(result);
        }

    }
}
