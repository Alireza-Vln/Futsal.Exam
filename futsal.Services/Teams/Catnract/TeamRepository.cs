using FutsalTeam.Entities;
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
        public List<Team> GetAllTeams();    
       public  void DeleteTeam(Team team);
    }
}
