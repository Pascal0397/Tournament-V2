using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLogic;

namespace TournamentUI
{
    public partial class TournamentUI : Form
    {

        public Button CreateTournament
        {
            get
            {
                return this.createTournamentButton;
            }
        }
        private TournamentModel tournamentModel;
        public TournamentModel TournamentModel
        {
            get
            {
                return this.tournamentModel;
            }
        }

        public TournamentUI()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void tournamentNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            this.tournamentModel = new TournamentModel();
            this.tournamentModel.NameOfTournament = tournamentNameTextBox.Text;
        }
    }
}
