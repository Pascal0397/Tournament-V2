using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLogic
{
    public class TeamModel
    {
        public string _players { get; set; }
        public string _teamName { get; set; }

        List<string> players = new List<string>();
        string nameOfTeam;
    }
}
