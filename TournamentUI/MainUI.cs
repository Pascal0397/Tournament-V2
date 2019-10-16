using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentUI
{
    public partial class MainUI : Form
    {
        private bool createTeamButtonWasClicked = false;
        public MainUI()
        {
            InitializeComponent();
        }

        private void tournamentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            DialogBoxes dialogBoxes = new DialogBoxes();
            createTeamButtonWasClicked = true;
            if (createTeamButtonWasClicked)
            {
                dialogBoxes.ShowDialogBox();
            }
        }
    }
}
