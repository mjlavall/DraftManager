namespace DraftManager.Forms
{
    partial class EditLeague
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
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.textBoxTeam = new System.Windows.Forms.TextBox();
            this.listBoxTeams = new System.Windows.Forms.ListBox();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonClearRosters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.Location = new System.Drawing.Point(12, 12);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.comboBoxLeague.Size = new System.Drawing.Size(192, 21);
            this.comboBoxLeague.TabIndex = 0;
            this.comboBoxLeague.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeague_SelectedIndexChanged);
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Location = new System.Drawing.Point(12, 38);
            this.textBoxTeam.Name = "textBoxTeam";
            this.textBoxTeam.Size = new System.Drawing.Size(192, 20);
            this.textBoxTeam.TabIndex = 1;
            // 
            // listBoxTeams
            // 
            this.listBoxTeams.FormattingEnabled = true;
            this.listBoxTeams.Location = new System.Drawing.Point(12, 94);
            this.listBoxTeams.Name = "listBoxTeams";
            this.listBoxTeams.Size = new System.Drawing.Size(192, 212);
            this.listBoxTeams.TabIndex = 3;
            this.listBoxTeams.DoubleClick += new System.EventHandler(this.listBoxTeams_DoubleClick);
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Location = new System.Drawing.Point(12, 65);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTeam.TabIndex = 2;
            this.buttonAddTeam.Text = "Add Team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(210, 144);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(50, 23);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.Text = "UP";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(210, 231);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(50, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "DEL";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(210, 173);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(50, 23);
            this.buttonDown.TabIndex = 6;
            this.buttonDown.Text = "DOWN";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonClearRosters
            // 
            this.buttonClearRosters.Location = new System.Drawing.Point(12, 312);
            this.buttonClearRosters.Name = "buttonClearRosters";
            this.buttonClearRosters.Size = new System.Drawing.Size(92, 23);
            this.buttonClearRosters.TabIndex = 7;
            this.buttonClearRosters.Text = "Clear Rosters";
            this.buttonClearRosters.UseVisualStyleBackColor = true;
            this.buttonClearRosters.Click += new System.EventHandler(this.buttonClearRosters_Click);
            // 
            // EditLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 342);
            this.Controls.Add(this.buttonClearRosters);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.listBoxTeams);
            this.Controls.Add(this.textBoxTeam);
            this.Controls.Add(this.comboBoxLeague);
            this.Name = "EditLeague";
            this.Text = "DraftSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLeague;
        private System.Windows.Forms.TextBox textBoxTeam;
        private System.Windows.Forms.ListBox listBoxTeams;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonClearRosters;
    }
}