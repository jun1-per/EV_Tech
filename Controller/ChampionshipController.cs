using System.Threading.Tasks;
using ICD.Base.BusinessServiceContract;
using ICD.Framework.Abstraction.Session;
using ICD.FrameWork.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ICD.Base.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionshipController : BaseController
    {
        private readonly IChampionshipService _championshipService;

        public ChampionshipController(IAppSession appSession, IChampionshipService championshipServise) : base(
            appSession)
        {
            _championshipService = championshipServise;
        }


        [HttpPost("get-All")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllChampionShip([FromBody] GetAllChampionshipQuery request)
        {
            var result = await _championshipService.GetAllChampionshipsAsync(request);
            return Ok(result);
        }


        [HttpPost("insert")]
        [AllowAnonymous]
        public async Task<IActionResult> InsertChampionShipAsync([FromBody] InsertChampionshipRequest request)
        {
            var result = await _championshipService.InsertChampionshipAsync(request);

            return Ok(result);
        }


        [HttpPost("update")]
        [AllowAnonymous]
        public async Task<IActionResult> UpdateChampionShipAsync([FromBody] UpdateChampionshipRequest request)
        {
            var result = await _championshipService.UpdateChampionshipAsync(request);

            return Ok(result);
        }


        [HttpPost("delete")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteChampionShipAsync([FromBody] DeleteTypeIntRequest request)
        {
            var result = await _championshipService.DeleteChampionshipAsync(request);

            return Ok(result);
        }
    }
}
