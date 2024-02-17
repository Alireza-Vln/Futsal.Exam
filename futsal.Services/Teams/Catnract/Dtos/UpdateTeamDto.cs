using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutsalTeam.Services.Teams.Catnract.Dtos
{
    public class UpdateTeamDto
    {
        public string TeamName { get; set; }
        public Color MainColor { get; set; }
        public Color SecondaryColor { get; set; }
    }
}
