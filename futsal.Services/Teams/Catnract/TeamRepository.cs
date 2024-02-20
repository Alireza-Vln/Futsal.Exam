using FutsalTeam.Entities;
using FutsalTeam.Services.Teams.Catnract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Services.Teams.Catnract
{
    public interface TeamRepository
    {
        public bool IsExistTeamName(string teamName);
        public Team IsEXistTeam(int id);
        public  void AddTeam(Team team);
        public List<GetTeamDto> GetAllTeams(TeamFilterDto filterDto);    
       public  void DeleteTeam(Team team);
    }
}
