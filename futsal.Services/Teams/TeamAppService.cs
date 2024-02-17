using Cantracts;
using FutsalTeam.Entities;
using FutsalTeam.Services.Teams.Catnract;
using FutsalTeam.Services.Teams.Catnract.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Services.Teams
{
    public class TeamAppService :TeamService
    {
         readonly TeamRepository _repository;
        readonly UnitOfWork _unitOfWork;
        public TeamAppService(TeamRepository repository,UnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
            _repository= repository;
        }

        public async Task AddTeam(AddTeamDto dto)
        {
            var team = new Team
            {
                TeamName = dto.TeamName,
                MainColor = dto.MainColor,
                SecondaryColor = dto.SecondaryColor,
            };
            if (_repository.IsExistTeamName(dto.TeamName))
            {
                throw new Exception("erorrrrr");
            }
            if (dto.MainColor == dto.SecondaryColor)
            {
                throw new Exception("erorrrrr");
            }
            _repository.AddTeam(team);
          await _unitOfWork.Complete();
        }

        public async Task DeleteTeam(int id)
        {

            _repository.DeleteTeam(_repository.IsEXistTeam(id));
            await _unitOfWork.Complete();

        }

        public async Task<List<Team>> GetAllTeam()
        {
           return _repository.GetAllTeams();
        }

        public async Task Update(UpdateTeamDto dto,int id)
        {
         var team =_repository.IsEXistTeam(id);
            if (team == null)
            {

                throw new Exception();
            
            }

            team.TeamName = dto.TeamName;
            team.MainColor = dto.MainColor;
            team.SecondaryColor = dto.SecondaryColor;
            await _unitOfWork.Complete();
        }
    }
}
