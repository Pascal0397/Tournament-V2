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
    public delegate void DataTransfer(string teamData);
    
    // TODO: Transfer Player Data
    public partial class MainUI : Form
    {
        public DataTransfer transferDelegate;
        
        private bool createTeamButtonWasClicked = false;

        public MainUI() 
        {
            InitializeComponent();
            transferDelegate += new DataTransfer(DataMethod);

            
        }


        public void DataMethod(string teamData)
        {
            tTeamsListBox.Items.Add(teamData);
        }


        private void tournamentNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainUI_Load(object sender, EventArgs e) 
        {
            //tTeamsListBox.Items.Add(TeamUI.passingText);
            //TeamUI team = new TeamUI();
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamUI teamUI = new TeamUI(transferDelegate);
            teamUI.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public void tTeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update Playwer List with Team Members
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
