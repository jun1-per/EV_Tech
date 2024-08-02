using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/gln")]
    [ApiController]
    public class GLNController : BaseController
    {
        private readonly IGLNService _glnService;

        public GLNController(IGLNService glnService, IAppSession appSession) : base(appSession)
        {
            _glnService = glnService;
        }
        [AllowAnonymous]
        [HttpPost("insert")]
        public async Task<IActionResult> InsertGLNAsync([FromBody] InsertGLNRequest request)
        {
            var result = await _glnService.InsertGLNAsync(request);
            return Ok(result);
        }

        [HttpPost("insert-list")]
        public async Task<IActionResult> InsertListGLNAsync([FromBody] InsertListGlnRequest request)
        {
            var result = await _glnService.InsertListGLNAsync(request);

            return Ok(result);
        }

        [HttpPost("insert-list-legal")]
        public async Task<IActionResult> InsertListLegalGLNAsync([FromBody] InsertListLegalGLNRequest request)
        {
            var result = await _glnService.InsertListLegalGLNAsync(request);

            return Ok(result);
        }
        
        [HttpPost("get")]
        public async Task<IActionResult> GetGLNAsync([FromBody] GetGLNQuery query)
        {
            var result = await _glnService.GetGLNAsync(query);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateGLNAsync([FromBody] UpdateGLNRequest request)
        {
            var result = await _glnService.UpdateGLNAsync(request);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteGLNAsync([FromBody] DeleteTypeLongRequest request)
        {
            var result = await _glnService.DeleteGLNByIdAsync(request);
            return Ok(result);
        }

        [HttpPost("get-by-company")]
        public async Task<IActionResult> GetGLNByCompanyAsync([FromBody] GetGLNByCompanyQuery query)
        {
            var result = await _glnService.GetGLNByCompanyAsync(query);
            return Ok(result);
        }
        
        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetGLNByKeyAsync([FromBody] GetGLNByKeyQuery query)
        {
            var result = await _glnService.GetGLNByKeyAsync(query);
            return Ok(result);
        }
    }
}
