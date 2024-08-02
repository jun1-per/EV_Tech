using System.Threading.Tasks;
using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ICD.Base.Api.Controller
{
    [Route("api/item-rows")]
    [ApiController]
    public class ItemRowController : BaseController
    {
        private readonly IItemRowService _itemRowService;

        public ItemRowController(IItemRowService itemRowService, IAppSession appSession) : base(appSession)
        {
            _itemRowService = itemRowService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertItemRowAsync([FromBody] InsertItemRowRequest request)
        {
            var result = await _itemRowService.InsertItemRowAsync(request);
            return Ok(result);
        }


        [HttpPost("get")]
        public async Task<IActionResult> GetItemRowsAsync([FromBody] GetItemRowsQuery query)
        {
            var result = await _itemRowService.GetItemRowsAsync(query);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteItemRowByIdAsync([FromBody] DeleteItemRowRequest request)
        {
            var result = await _itemRowService.DeleteItemRowByIdAsync(request);
            return Ok(result);
        }

    }
}