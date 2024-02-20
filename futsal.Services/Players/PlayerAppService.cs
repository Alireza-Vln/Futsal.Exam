using Cantracts;
using FutsalTeam.Entities;
using FutsalTeam.Services.Players.Cantarcts;
using FutsalTeam.Services.Players.Cantarcts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Services.Players
{
    public class PlayerAppService : PlayersServices
    {
        readonly PlayerRepository _repository;
        readonly UnitOfWork _unitOfWork;
        public PlayerAppService(PlayerRepository repository,UnitOfWork unitOfWork)
        {
            _repository= repository;
            _unitOfWork= unitOfWork;
        }
        public async Task AddPlayers(AddPlayersDto dto,int id)
        {
            var team =  _repository.IsEXistTeam(id);

            var player = new Player
            {
                FirstName = dto.FristName,
                LastName = dto.LastName,
                Age = dto.Age,
                Team=team,
                TeamId = team.Id
                

            };
            team.players.Add(player);
            _repository.AddPlayer(player); 
            await _unitOfWork.Complete();
        }

        public async Task DeletePlayer(int id)
        {
            var player = _repository.IsExistPlayer(id);
             _repository.DeletePlayer(player);
         await  _unitOfWork.Complete();
        }

        public async Task<List<GetPlayersDto>> GetPlayers()
        {
            return _repository.GetAllPlayers();
        }
    }
}
