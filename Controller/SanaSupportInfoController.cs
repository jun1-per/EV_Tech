using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/Sana-Support-Info")]
    [ApiController]
    public class SanaSupportInfoController : BaseController
    {
        private readonly ISanaSupportInfoService _sanaSupportInfoService;

        public SanaSupportInfoController(ISanaSupportInfoService sanaSupportInfoService, IAppSession appSession) : base(appSession)
        {
            _sanaSupportInfoService = sanaSupportInfoService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertSanaSupportInfoAsync([FromBody] InsertSanaSupportInfoRequest request)
        {
            var result = await _sanaSupportInfoService.InsertSanaSupportInfoAsync(request);

            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateSanaSupportInfoAsync([FromBody] UpdateSanaSupportInfoRequest request)
        {
            var result = await _sanaSupportInfoService.UpdateSanaSupportInfoAsync(request);

            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteSanaSupportInfoAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _sanaSupportInfoService.DeleteSanaSupportInfoAsync(request);

            return Ok(result);
        }

        [AllowAnonymous]
        [HttpPost("get")]
        public async Task<IActionResult> GetSanaSupportInfoAsync([FromBody] GetSanaSupportInfoQuery query)
        {
            var result = await _sanaSupportInfoService.GetSanaSupportInfoAsync(query);

            return Ok(result);
        }
    }
}
