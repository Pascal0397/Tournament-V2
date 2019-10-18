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
    public partial class TeamUI : Form
    {
        public static string passingText = "";
       // DataTransfer transferDel;
        
        public Button CreateTeam
        {
            get
            {
                return this.createTeamButton;
            }
        }

        public TeamUI()
        {
            InitializeComponent();
            /* transferDel = teamDel;
            DataTransfer teamDel */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeamUI_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createPlayerLabel_Click(object sender, EventArgs e)
        {

        }

        private void createNewPlayerTextBox_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            if (validateBox())
            {
                playerAddedListBox.Items.Add(createNewPlayerTextBox.Text);
                createNewPlayerTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid Player Name");
            }
        }

        private bool validateBox()
        {
            if (createNewPlayerTextBox.TextLength == 0)
            {
                return false;
            }
            return true;
        }

        private void removeSelectedButton_Click(object sender, EventArgs e)
        {
            if (playerAddedListBox.SelectedIndex != -1)
            {
                playerAddedListBox.Items.RemoveAt(playerAddedListBox.SelectedIndex);
            }
        }


        private TeamModel teamModel;
        public TeamModel TeamModel
        {
            get
            {
                return this.teamModel;
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            this.teamModel = new TeamModel();
            this.teamModel.TeamName = createTeamTextBox.Text;
            

            //transferDel.Invoke(teamData);
            
            
            createTeamTextBox.Clear();
            Close();
        }

        public void playerAddedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void createTeamTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
