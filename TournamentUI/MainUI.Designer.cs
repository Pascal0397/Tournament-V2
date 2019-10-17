namespace TournamentUI
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.btnCreateTorunament = new System.Windows.Forms.Button();
            this.tTeamsListBox = new System.Windows.Forms.ListBox();
            this.tPlayersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentLabel.ForeColor = System.Drawing.Color.Red;
            this.tournamentLabel.Location = new System.Drawing.Point(16, 11);
            this.tournamentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(271, 62);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentNameLabel.Location = new System.Drawing.Point(29, 73);
            this.tournamentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(140, 46);
            this.tournamentNameLabel.TabIndex = 1;
            this.tournamentNameLabel.Text = "<none>";
            this.tournamentNameLabel.Click += new System.EventHandler(this.tournamentNameLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1860, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "<Placeholder>";
            // 
            // createTeamButton
            // 
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.DarkRed;
            this.createTeamButton.Location = new System.Drawing.Point(1222, 11);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(252, 66);
            this.createTeamButton.TabIndex = 5;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            this.createTeamButton.Click += new System.EventHandler(this.createTeamButton_Click);
            // 
            // btnCreateTorunament
            // 
            this.btnCreateTorunament.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTorunament.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCreateTorunament.Location = new System.Drawing.Point(901, 11);
            this.btnCreateTorunament.Name = "btnCreateTorunament";
            this.btnCreateTorunament.Size = new System.Drawing.Size(315, 66);
            this.btnCreateTorunament.TabIndex = 6;
            this.btnCreateTorunament.Text = "Create Tournament";
            this.btnCreateTorunament.UseVisualStyleBackColor = true;
            this.btnCreateTorunament.Click += new System.EventHandler(this.btnCreateTorunament_Click);
            // 
            // tTeamsListBox
            // 
            this.tTeamsListBox.AccessibleName = "tTeamsListBox";
            this.tTeamsListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tTeamsListBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTeamsListBox.FormattingEnabled = true;
            this.tTeamsListBox.ItemHeight = 37;
            this.tTeamsListBox.Location = new System.Drawing.Point(1211, 521);
            this.tTeamsListBox.Name = "tTeamsListBox";
            this.tTeamsListBox.Size = new System.Drawing.Size(262, 411);
            this.tTeamsListBox.TabIndex = 7;
            this.tTeamsListBox.SelectedIndexChanged += new System.EventHandler(this.tTeamsListBox_SelectedIndexChanged);
            // 
            // tPlayersListBox
            // 
            this.tPlayersListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tPlayersListBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPlayersListBox.FormattingEnabled = true;
            this.tPlayersListBox.ItemHeight = 37;
            this.tPlayersListBox.Location = new System.Drawing.Point(925, 521);
            this.tPlayersListBox.Name = "tPlayersListBox";
            this.tPlayersListBox.Size = new System.Drawing.Size(270, 411);
            this.tPlayersListBox.TabIndex = 8;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1486, 944);
            this.Controls.Add(this.tPlayersListBox);
            this.Controls.Add(this.tTeamsListBox);
            this.Controls.Add(this.btnCreateTorunament);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.tournamentLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainUI";
            this.Text = "Tournament Overview";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createTeamButton;
        private System.Windows.Forms.Button btnCreateTorunament;
        private System.Windows.Forms.ListBox tPlayersListBox;
        public System.Windows.Forms.ListBox tTeamsListBox;
    }
}