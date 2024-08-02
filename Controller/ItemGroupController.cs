using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/item-groups")]
    [ApiController]
    public class ItemGroupController : BaseController
    {
        private readonly IItemGroupService _itemGroupService;

        public ItemGroupController(IItemGroupService itemGroupService, IAppSession appSession) : base(appSession)
        {
            _itemGroupService = itemGroupService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertItemGroupAsync([FromBody] InsertItemGroupRequest request)
        {
            var result = await _itemGroupService.InsertItemGroupAsync(request);
            return Ok(result);
        }

        [HttpPost("get")]
        public async Task<IActionResult> GetItemGroupsByApplicationRefAsync([FromBody] GetItemGroupsQuery query)
        {

            var result = await _itemGroupService.GetItemGroupsByApplicationRefAsync(query);
            return Ok(result);
        }

        [HttpPost("delete")]
        public async Task<IActionResult> DeleteItemGroupByIdAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _itemGroupService.DeleteItemGroupByIdAsync(request);
            return Ok(result);
        }

        [HttpPost("update")]
        public async Task<IActionResult> UpdateItemGroupByIdAsync([FromBody] UpdateItemGroupRequest request)
        {
            var result = await _itemGroupService.UpdateItemGroupByid(request);
            return Ok(result);
        }

        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetItemGroupsByKeyAsync([FromBody] GetItemGroupsByKeyQuery query)
        {

            var result = await _itemGroupService.GetItemGroupsByKeyAsync(query);
            return Ok(result);
        }
    }
}