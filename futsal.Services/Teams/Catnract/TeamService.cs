using FutsalTeam.Entities;
using FutsalTeam.Services.Teams.Catnract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Services.Teams.Catnract
{
    public interface TeamService
    {
        public Task AddTeam(AddTeamDto dto);
        public Task <List<GetTeamDto>> GetAllTeam(TeamFilterDto? filterDto);
        public Task DeleteTeam(int id);
        public Task Update(UpdateTeamDto dto,int id);
    }
}
