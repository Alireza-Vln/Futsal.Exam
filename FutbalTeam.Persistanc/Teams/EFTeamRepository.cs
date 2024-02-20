using FutsalTeam.Entities;
using FutsalTeam.Services.Teams.Catnract;
using FutsalTeam.Services.Teams.Catnract.Dtos;
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

       

     

        public Team IsEXistTeam(int id)
        {
            var team = _context.Teams.FirstOrDefault(_ => _.Id == id);
            return team;
        }

        public bool IsExistTeamName(string teamName)
        {
          return  _context.Teams.Any(_ => _.TeamName == teamName);
        }

      public List<GetTeamDto> GetAllTeams(TeamFilterDto? filterDto)
        {

            var team = _context.Teams.Select(_ => new GetTeamDto
            {
                Id = _.Id,
                TeamName = _.TeamName,
                SecondaryColor = _.SecondaryColor,
                MainColor = _.MainColor,
                Players=_.players,
                
            }).ToList();
            if (filterDto.Id != null)
            {
                team=team.Where(_=>_.Id==filterDto.Id).ToList();
            }
            if (filterDto.TeamName!=null)
            {
                team=team.Where(_=>_.TeamName.Contains(filterDto.TeamName)).ToList();
            }
            if (filterDto.Color != null)
            {
                team=team.Where(_=>_.MainColor==filterDto.Color ||
                 _.SecondaryColor==filterDto.Color).ToList();  
            }

            return team.ToList();
        }
    }
}
