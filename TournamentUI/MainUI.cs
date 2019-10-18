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
    
    
   // public delegate void DataTransfer(TeamModel teamData);
    
    // TODO: Transfer Player Data
    public partial class MainUI : Form
    {
       // public DataTransfer transferDelegate;
        
        private bool createTeamButtonWasClicked = false;

        public MainUI() 
        {
            InitializeComponent();
            //transferDelegate += new DataTransfer(DataMethod);

            
        }


         /* public void DataMethod(TeamModel teamData)
        {
           tTeamsListBox.Items.Add(teamData);
        } */
        

        private void tournamentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e) 
        {
            tTeamsListBox.Items.Add(TeamUI.passingText);
            TeamUI team = new TeamUI();
        }

        private TeamUI teamUI;
        private void createTeamButton_Click(object sender, EventArgs e)
        {
            this.teamUI = new TeamUI();
            this.teamUI.CreateTeam.Click += CreateTeam_Click;
            
            this.teamUI.ShowDialog();
        }

        private void CreateTeam_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.teamUI.TeamModel.TeamName);
            Console.WriteLine(this.teamUI.TeamModel.TeamName);
            tTeamsListBox.Items.Add(this.teamUI.TeamModel.TeamName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public void tTeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCreateTorunament_Click(object sender, EventArgs e)
        {
            TournamentUI tournamentUI = new TournamentUI();
            tournamentUI.ShowDialog();
        }

        public void tPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
