using FutsalTeam.Entities;
using FutsalTeam.Services.Teams.Catnract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Persistanc.Teams
{
    public class EFTeamRepository : TeamRepository
    {
        private readonly EFDataContext _context;
        public EFTeamRepository(EFDataContext context)
        {
            _context= context;
        }
        public void AddTeam(Team team)
        {
            _context.Teams.Add(team);
         
             
        }

        public void DeleteTeam(Team team)
        {
             _context.Remove(team);
        }

        public List<Team> GetAllTeams()
        {
           return _context.Teams.ToList();
        }

     

        public Team IsEXistTeam(int id)
        {
            var team = _context.Teams.FirstOrDefault(_ => _.Id == id);
            return team;
        }

        public bool IsExistTeamName(string teamName)
        {
          return  _context.Teams.Any(_ => _.TeamName == teamName);
        }

       
    }
}
