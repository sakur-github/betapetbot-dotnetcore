using System;
using System.Threading.Tasks;
using BetapetBotDotNetCore.Managers;
using BetapetBotDotNetCore.Models;
using BetapetBotDotNetCore.Models.Api.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BetapetBotDotNetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotController : ControllerBase
    {
        [HttpGet()]
        public async Task<ActionResult<GameResponse>> GetGameResponse()
        {
            ApiManager manager = new ApiManager();
            LoginResponse apiResponse = await manager.Login("davidrdrgz", "gunnaral");

            return new GameResponse(apiResponse);
        }
    }
}
