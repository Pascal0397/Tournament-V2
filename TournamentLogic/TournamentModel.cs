using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLogic
{
    public class TournamentModel
    {
        public List<GameModel> Games { get; set; }
        public List<TeamModel> Teams { get; set; }
        public string NameOfTournament { get; set; }
    }
}
