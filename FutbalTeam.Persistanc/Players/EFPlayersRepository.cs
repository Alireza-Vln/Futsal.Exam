using FutsalTeam.Entities;
using FutsalTeam.Services.Players.Cantarcts;
using FutsalTeam.Services.Players.Cantarcts.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Persistanc.Players
{
    public class EFPlayersRepository:PlayerRepository
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

        public List<GetPlayersDto> GetAllPlayers()
        {

            return _context.Set<Player>().Include(_ => _.Team).Select(_ => new GetPlayersDto
            {
                Id = _.Id,
                FirstName = _.FirstName,
                LastName = _.LastName,
                TeamName = _.Team.TeamName,
                Age=(DateTime.UtcNow - _.Age).Days/365



            }).ToList();
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
