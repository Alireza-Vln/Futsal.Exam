using FutsalTeam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Services.Teams.Catnract.Dtos
{
    public class GetTeamDto
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public Color MainColor { get; set; }
        public Color SecondaryColor { get; set; }
        public HashSet<Player> Players { get; set; }
    }
}
