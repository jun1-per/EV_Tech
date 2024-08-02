using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/expense-centers")]
    [ApiController]
    public class ExpenseCenterController : BaseController
    {
        private readonly IExpenseCenterService _expenseCenterService;
        public ExpenseCenterController(IExpenseCenterService expenseCenterService, IAppSession appSession) : base(appSession)
        {
            _expenseCenterService = expenseCenterService;
        }

        [HttpPost("insert")]
        public async Task<IActionResult> InsertExpenseCenterAsync([FromBody] InsertExpenseCenterRequest request)
        {
            var res = await _expenseCenterService.InsertExpenseCenterAsync(request);

            return Ok(res);
        }
        [HttpPost("update")]
        public async Task<IActionResult> UpdateExpenseCenterAsync([FromBody] UpdateExpenseCenterRequest request)
        {
            var res = await _expenseCenterService.UpdateExpenseCenterAsync(request);

            return Ok(res);
        }
        [HttpPost("delete")]
        public async Task<IActionResult> DeleteExpenseCenterAsync([FromBody] DeleteTypeLongRequest request)
        {
            var res = await _expenseCenterService.DeleteExpenseCenterAsync(request);

            return Ok(res);
        }
        [HttpPost("get")]
        public async Task<IActionResult> GetExpenseCentersAsync([FromBody] GetExpenseCentersQuery query)
        {
            var res = await _expenseCenterService.GetExpenseCentersAsync(query);

            return Ok(res);
        }

        [HttpPost("get-by-key")]
        public async Task<IActionResult> GetExpenseCenterByKeyAsync([FromBody] GetExpenseCenterByKeyQuery query)
        {
            var res = await _expenseCenterService.GetExpenseCenterByKeyAsync(query);

            return Ok(res);
        }
    }
}