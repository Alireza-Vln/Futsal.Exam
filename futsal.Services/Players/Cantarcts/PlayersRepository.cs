using FutsalTeam.Entities;
using FutsalTeam.Services.Players.Cantarcts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Services.Players.Cantarcts
{
   public interface PlayersRepository
    {
        public Team IsEXistTeam(int id);
        public Player IsExistPlayer(int id);
        List<Player> GetAllPlayers();
        void DeletePlayer(Player player);
        void AddPlayer(Player player);
   
    }
}
