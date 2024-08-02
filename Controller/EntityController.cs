using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using ICD.Infrastructure;
using ICD.Infrastructure.BusinessServiceContract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controllers
{
    [Route("api/entity")]
    [ApiController]
    public class EntityController : BaseController
    {
        private readonly IEntityService _entityService;

        public EntityController(IEntityService entityService, IAppSession appSession) : base(appSession)
        {
            _entityService = entityService;
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetEntitiesByLanguageAsync([FromBody] GetEntityByLanguageQuery request)
        {
            var result = await _entityService.GetEntityByLanguageAsync(request);

            return Ok(result);
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertEntityAsync([FromBody] InsertEntityRequest request)
        {
            var result = await _entityService.InsertEntityAsync(request);

            return Ok(result);
        }

        [HttpPost("insert-multilingual")]
        public async Task<IActionResult> InsertMultiLingualEntityAsync([FromBody] InsertMultiLingualEntity request)
        {
            var result = await _entityService.InsertMultilingualEntityAsync(request);

            return Ok(result);
        }

        // hesam call this.
        [HttpPost("auto-translate")]
        [AllowAnonymous]
        public async Task<IActionResult> AutoTranslateEntityAsync([FromBody] AutoTranslateEntityRequest request)
        {
            var result = await _entityService.AutoTranslateAsync(request);
            return Ok(result);
        }
    }
}