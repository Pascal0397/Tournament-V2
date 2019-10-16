namespace TournamentUI
{
    partial class TeamUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamUI));
            this.createTeamLabel = new System.Windows.Forms.Label();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.playerAddedListBox = new System.Windows.Forms.ListBox();
            this.createNewPlayerLabel = new System.Windows.Forms.Label();
            this.createNewPlayerTextBox = new System.Windows.Forms.TextBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.removeSelectedButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTeamLabel
            // 
            this.createTeamLabel.AutoSize = true;
            this.createTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamLabel.ForeColor = System.Drawing.Color.Red;
            this.createTeamLabel.Location = new System.Drawing.Point(401, 11);
            this.createTeamLabel.Name = "createTeamLabel";
            this.createTeamLabel.Size = new System.Drawing.Size(272, 62);
            this.createTeamLabel.TabIndex = 0;
            this.createTeamLabel.Text = "Create Team";
            this.createTeamLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createTeamLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.teamNameLabel.Location = new System.Drawing.Point(40, 107);
            this.teamNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(204, 46);
            this.teamNameLabel.TabIndex = 1;
            this.teamNameLabel.Text = "Team Name:";
            this.teamNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.playerLabel.Location = new System.Drawing.Point(463, 123);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(131, 46);
            this.playerLabel.TabIndex = 2;
            this.playerLabel.Text = "Players:";
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.teamNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamNameTextBox.Location = new System.Drawing.Point(49, 156);
            this.teamNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamNameTextBox.Multiline = true;
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(347, 45);
            this.teamNameTextBox.TabIndex = 3;
            this.teamNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playerAddedListBox
            // 
            this.playerAddedListBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.playerAddedListBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerAddedListBox.FormattingEnabled = true;
            this.playerAddedListBox.ItemHeight = 36;
            this.playerAddedListBox.Location = new System.Drawing.Point(472, 172);
            this.playerAddedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.playerAddedListBox.Name = "playerAddedListBox";
            this.playerAddedListBox.Size = new System.Drawing.Size(347, 508);
            this.playerAddedListBox.TabIndex = 4;
            // 
            // createNewPlayerLabel
            // 
            this.createNewPlayerLabel.AutoSize = true;
            this.createNewPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewPlayerLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.createNewPlayerLabel.Location = new System.Drawing.Point(40, 236);
            this.createNewPlayerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createNewPlayerLabel.Name = "createNewPlayerLabel";
            this.createNewPlayerLabel.Size = new System.Drawing.Size(295, 46);
            this.createNewPlayerLabel.TabIndex = 5;
            this.createNewPlayerLabel.Text = "Create new Player:";
            this.createNewPlayerLabel.Click += new System.EventHandler(this.createPlayerLabel_Click);
            // 
            // createNewPlayerTextBox
            // 
            this.createNewPlayerTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.createNewPlayerTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewPlayerTextBox.Location = new System.Drawing.Point(49, 286);
            this.createNewPlayerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createNewPlayerTextBox.Multiline = true;
            this.createNewPlayerTextBox.Name = "createNewPlayerTextBox";
            this.createNewPlayerTextBox.Size = new System.Drawing.Size(347, 45);
            this.createNewPlayerTextBox.TabIndex = 6;
            this.createNewPlayerTextBox.TextChanged += new System.EventHandler(this.createNewPlayerTextBox_TextChanged);
            // 
            // addMemberButton
            // 
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.DarkRed;
            this.addMemberButton.Location = new System.Drawing.Point(49, 338);
            this.addMemberButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(256, 50);
            this.addMemberButton.TabIndex = 7;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // removeSelectedButton
            // 
            this.removeSelectedButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedButton.ForeColor = System.Drawing.Color.DarkRed;
            this.removeSelectedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeSelectedButton.Location = new System.Drawing.Point(828, 172);
            this.removeSelectedButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeSelectedButton.Name = "removeSelectedButton";
            this.removeSelectedButton.Size = new System.Drawing.Size(223, 85);
            this.removeSelectedButton.TabIndex = 8;
            this.removeSelectedButton.Text = "Remove Selected";
            this.removeSelectedButton.UseVisualStyleBackColor = true;
            this.removeSelectedButton.Click += new System.EventHandler(this.removeSelectedButton_Click);
            // 
            // createTeamButton
            // 
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.DarkRed;
            this.createTeamButton.Location = new System.Drawing.Point(49, 612);
            this.createTeamButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(348, 82);
            this.createTeamButton.TabIndex = 9;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // TeamUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1087, 736);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.removeSelectedButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.createNewPlayerTextBox);
            this.Controls.Add(this.createNewPlayerLabel);
            this.Controls.Add(this.playerAddedListBox);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.createTeamLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeamUI";
            this.Text = "Create Team";
            this.Load += new System.EventHandler(this.TeamUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createTeamLabel;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.ListBox playerAddedListBox;
        private System.Windows.Forms.Label createNewPlayerLabel;
        private System.Windows.Forms.TextBox createNewPlayerTextBox;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button removeSelectedButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}

