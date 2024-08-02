using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/Location")]
    [ApiController]
    public class LocationController : BaseController
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService, IAppSession appSession) : base(appSession)
        {
            _locationService = locationService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertLocationAsync([FromBody] InsertLocationRequest request)
        {
            var result = await _locationService.InsertLocationAsync(request);
            return Ok(result);
        }


        [HttpPost("get")]
        public async Task<IActionResult> GetLocationAsync([FromBody] GetLocationQuery query)
        {
            var result = await _locationService.GetLocationAsync(query);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateLocationAsync([FromBody] UpdateLocationRequest request)
        {
            var result = await _locationService.UpdateLocationAsync(request);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteLocationAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _locationService.DeleteLocationByIdAsync(request);
            return Ok(result);
        }
    }
}