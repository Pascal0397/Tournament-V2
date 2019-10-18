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
    // TODO: Remove delegate stuff
    // TODO: Set TeamModelData in MainUI
    // TODO: Transfer Player Data
    public partial class MainUI : Form
    {
        private bool createTeamButtonWasClicked = false;
        
        public string TournamentLabel 
        {
            get
            {
                return this.tournamentNameLabel.Text;
            }
            set
            {
                this.tournamentNameLabel.Text = value;
            }
        }

        public MainUI() 
        {
            InitializeComponent();
        }

        private void tournamentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e) 
        {
            tTeamsListBox.Items.Add(TeamUI.passingText);
            TeamUI team = new TeamUI();
        }

        private TeamUI teamUI;
        private TournamentUI tournamentUI;
        private void createTeamButton_Click(object sender, EventArgs e)
        {
            this.teamUI = new TeamUI();
            
            this.teamUI.CreateTeam.Click += CreateTeam_Click;
            this.tournamentUI.CreateTournament.Click += btnCreateTorunament_Click;
            
            this.teamUI.ShowDialog();
        }

        private void CreateTeam_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.teamUI.TeamModel.TeamName);
            Console.WriteLine(this.teamUI.TeamModel.Players);
            
            tTeamsListBox.Items.Add(this.teamUI.TeamModel.TeamName);
            

            foreach (var item in teamUI.TeamModel.Players)
            {
                tPlayersListBox.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public void tTeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreateTorunament_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.tournamentUI.TournamentModel.NameOfTournament);
            this.tournamentUI = new TournamentUI();
            tournamentNameLabel.Name = this.tournamentUI.TournamentModel.NameOfTournament;
            tournamentUI.ShowDialog();
        }

        public void tPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
