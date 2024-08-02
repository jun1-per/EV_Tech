using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using ICD.Infrastructure.BusinessServiceContract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ICD.Base.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : BaseController
    {
        private readonly ITeamService _teamService;
        public TeamController(IAppSession appSession, ITeamService teamService) : base(appSession)
        {
            _teamService = teamService;
        }

        [HttpPost("insert")]
        [AllowAnonymous]
        public async Task<IActionResult> InsertTeamAsync([FromBody] InsertTeamRequest request)
        {
            var result = await _teamService.InsertTeamAsync(request);

            return Ok(result);
        }

        [HttpPost("get-team")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllTeamsspecificchampionshipAsync([FromBody] GetTeamsBySpecificChampionshipQuery request)
        {
            var result = await _teamService.GetTeamsBySpecificChampionshipAsync(request);

            return Ok(result);
        }

        [HttpPost("remove-team-in-championship")]
        [AllowAnonymous]
        public async Task<IActionResult> RemoveTeamInChampionShip([FromBody] RemoveTeamFromChampionshipRequest request)
        {
            var result = await _teamService.RemoveTeamFromChampionshipAsync(request);

            return Ok(result);
        }
    }
}
