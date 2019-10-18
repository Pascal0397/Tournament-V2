using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLogic
{
    public class TeamModel
    {
        public string TeamName { get; set; }

        public List<string> Players { get; set; } = new List<string>();

    }
}
