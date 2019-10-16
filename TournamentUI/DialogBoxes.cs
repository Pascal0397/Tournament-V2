using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentUI
{
    public class DialogBoxes
    {
        public void ShowDialogBox()
        {
            TournamentUI tournamentUI = new TournamentUI();

            tournamentUI.ShowDialog(this);
            tournamentUI.Dispose();
        }
    }
}
