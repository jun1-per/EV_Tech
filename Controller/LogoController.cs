using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/logos")]
    [ApiController]
    public class LogoController : BaseController
    {
        private readonly ILogoService _logoService;

        public LogoController(ILogoService logoService, IAppSession appSession) : base(appSession)
        {
            _logoService = logoService;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetLogoAsync([FromBody] GetLogoQuery query)
        {
            var result = await _logoService.GetLogoAsync(query);
            return Ok(result);
        }
    }
}
