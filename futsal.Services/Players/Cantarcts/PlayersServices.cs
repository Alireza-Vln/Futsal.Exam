using FutsalTeam.Entities;
using FutsalTeam.Services.Players.Cantarcts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Services.Players.Cantarcts
{
    public interface PlayersServices
    {
        public Task DeletePlayer(int id);
        public Task AddPlayers(AddPlayersDto dto,int id);
        public Task<List<GetPlayersDto>> GetPlayers(); 
    }
}
