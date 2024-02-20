using FutsalTeam.Entities;
using FutsalTeam.Services.Teams.Catnract;
using FutsalTeam.Services.Teams.Catnract.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FutsalTeam.RestApi.Controllers.TeamsController
{
    [ApiController]
    [Route("Api/Team")]
    public class TeamController : Controller
    {
        readonly TeamService _service;
        public TeamController(TeamService service)
        {
            _service= service;
        }

        [HttpPost]
        public async Task Add([FromBody]AddTeamDto dto)
        {
            await _service.AddTeam(dto);
        }
        [HttpDelete]
        public async Task Delete([FromQuery]int id)
        {
           await _service.DeleteTeam(id);
        }
        [HttpGet("AllTeam")]
        public async Task<List<GetTeamDto>> GetAllTeam([FromQuery]TeamFilterDto? filterDto)
        {
            return await _service.GetAllTeam(filterDto);
        }
        [HttpPatch]
        public async Task UpdateTeam([FromHeader]int id, [FromBody]UpdateTeamDto dto)
        {

            await _service.Update(dto, id);
        
        }

    }
}
