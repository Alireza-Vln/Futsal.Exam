using FutsalTeam.Entities;
using FutsalTeam.Services.Players.Cantarcts;
using FutsalTeam.Services.Players.Cantarcts.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FutsalTeam.RestApi.Controllers.PlayersController
{
    [ApiController]
    [Route("Api/Player")]
    public class PlayersController : Controller
    {
        readonly PlayersServices _service;
       public PlayersController(PlayersServices service)
        {
                _service= service;
        }



        [HttpPost]
        public async Task Addplayer([FromBody]AddPlayersDto dto,[FromQuery] int id)
        {
            await _service.AddPlayers(dto, id);
        }
        [HttpDelete]
        public async Task DeletePlayer([FromQuery]int id)
        {
            await _service.DeletePlayer(id);
        }

    }
}
