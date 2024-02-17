using FutsalTeam.Entities;
using FutsalTeam.Services.Players.Cantarcts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Persistanc.Players
{
    public class EFPlayersRepository:PlayersRepository
    {
        readonly EFDataContext _context;
        public EFPlayersRepository(EFDataContext context)
        {
                _context= context;
        }

        public void AddPlayer(Player player)
        {
            _context.Add(player);
        }

        public void DeletePlayer(Player player)
        {
            _context.Remove(player);   
        }

        public List<Player> GetAll()
        {
            return _context.Players.ToList();
        }

        public List<Player> GetAllPlayers()
        {
            throw new NotImplementedException();
        }

        public Player IsExistPlayer(int id)
        {
            return _context.Players.FirstOrDefault(_ => _.Id == id);
        }

        public Team IsEXistTeam(int id)
        {
            return _context.Teams.FirstOrDefault(_ => _.Id == id);
        }
    }
}
