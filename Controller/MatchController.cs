using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ICD.Base.Match.Queries;

namespace ICD.Base.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : BaseController
    {
        private readonly IMatchService _matchService;

        public MatchController(IAppSession appSession, IMatchService matchService) : base(appSession)
        {
            _matchService = matchService;
        }

        [HttpPost("insert")]
        [AllowAnonymous]
        public async Task<IActionResult> InsertMatchAsync([FromBody] InsertMatchRequest request)
        {
            var result = await _matchService.InsertMatchAsync(request);

            return Ok(result);
        }


        [HttpPost("update")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateMatchAsync([FromBody] UpdateMatchRequest request)
        {
            var result = await _matchService.UpdateMatchAsync(request);

            return Ok(result);
        }

        [HttpPost("get-by-ChampionshipName")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPersonTestsByNameAsync([FromBody] GetUpComingMatchinChampionshipQuery query)
        {
            var result = await _matchService.GetUpcomingMatchesinChampionship(query);

            return Ok(result);
        }

    }
}
