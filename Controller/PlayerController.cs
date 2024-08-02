using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ICD.Base.Player.Commands;

namespace ICD.Base.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : BaseController
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IAppSession appSession, IPlayerService playerService) : base(appSession)
        {
            _playerService= playerService;
        }

        [HttpPost("insert")]
        [AllowAnonymous]
        public async Task<IActionResult> InsertplayerAsync([FromBody] InsertPlayerRequest request)
        {
            var result = await _playerService.InsertPlayerAsync(request);

            return Ok(result);
        }


        [HttpPost("update")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdtePlayerAsync([FromBody] UpdatePlayerRequest request)
        {
            var result = await _playerService.UpdatePlayerAsync(request);

            return Ok(result);
        }

        [HttpPost("get-by-teamID")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPlayerByTeamAsync([FromBody] GetPlayersByTeamQuery query)
        {
            var result = await _playerService.GetplayersInTeamAsync(query);

            return Ok(result);
        }

        [HttpPost("remove-player-from-team")]
        [AllowAnonymous]
        public async Task<IActionResult> removePlayerFromTeamAsyn([FromBody] RemovePlayerFromTeamRequest query)
        {
            var result = await _playerService.RemovePlayerFromTeamAsync(query);

            return Ok(result);
        }

    }
}
