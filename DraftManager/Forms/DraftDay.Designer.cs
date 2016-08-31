namespace DraftManager.Forms
{
    partial class DraftDay
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
            this.listBoxAvailablePlayers = new System.Windows.Forms.ListBox();
            this.labelRoundInfo = new System.Windows.Forms.Label();
            this.listBoxRoster = new System.Windows.Forms.ListBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.listBoxMyTeam = new System.Windows.Forms.ListBox();
            this.labelCurrentTeam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.comboBoxLeague = new System.Windows.Forms.ComboBox();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAvailablePlayers
            // 
            this.listBoxAvailablePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.listBoxAvailablePlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxAvailablePlayers.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAvailablePlayers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxAvailablePlayers.FormattingEnabled = true;
            this.listBoxAvailablePlayers.Location = new System.Drawing.Point(17, 99);
            this.listBoxAvailablePlayers.Name = "listBoxAvailablePlayers";
            this.listBoxAvailablePlayers.Size = new System.Drawing.Size(315, 416);
            this.listBoxAvailablePlayers.TabIndex = 0;
            this.listBoxAvailablePlayers.DoubleClick += new System.EventHandler(this.listBoxAvailablePlayers_DoubleClick);
            // 
            // labelRoundInfo
            // 
            this.labelRoundInfo.AutoSize = true;
            this.labelRoundInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoundInfo.Location = new System.Drawing.Point(12, 9);
            this.labelRoundInfo.Name = "labelRoundInfo";
            this.labelRoundInfo.Size = new System.Drawing.Size(362, 33);
            this.labelRoundInfo.TabIndex = 1;
            this.labelRoundInfo.Text = "Round # - Current Player";
            // 
            // listBoxRoster
            // 
            this.listBoxRoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.listBoxRoster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxRoster.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRoster.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxRoster.FormattingEnabled = true;
            this.listBoxRoster.Location = new System.Drawing.Point(338, 99);
            this.listBoxRoster.Name = "listBoxRoster";
            this.listBoxRoster.Size = new System.Drawing.Size(365, 416);
            this.listBoxRoster.TabIndex = 2;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxFilter.Location = new System.Drawing.Point(17, 75);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(243, 20);
            this.textBoxFilter.TabIndex = 5;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.comboBoxFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxFilter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(266, 75);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(66, 21);
            this.comboBoxFilter.TabIndex = 6;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // listBoxMyTeam
            // 
            this.listBoxMyTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.listBoxMyTeam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxMyTeam.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMyTeam.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxMyTeam.FormattingEnabled = true;
            this.listBoxMyTeam.Location = new System.Drawing.Point(709, 99);
            this.listBoxMyTeam.Name = "listBoxMyTeam";
            this.listBoxMyTeam.Size = new System.Drawing.Size(351, 416);
            this.listBoxMyTeam.TabIndex = 7;
            // 
            // labelCurrentTeam
            // 
            this.labelCurrentTeam.AutoSize = true;
            this.labelCurrentTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTeam.Location = new System.Drawing.Point(335, 76);
            this.labelCurrentTeam.Name = "labelCurrentTeam";
            this.labelCurrentTeam.Size = new System.Drawing.Size(95, 16);
            this.labelCurrentTeam.TabIndex = 8;
            this.labelCurrentTeam.Text = "currentTeam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "My Team";
            // 
            // buttonRevert
            // 
            this.buttonRevert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonRevert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRevert.Location = new System.Drawing.Point(1005, 12);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(55, 50);
            this.buttonRevert.TabIndex = 10;
            this.buttonRevert.Text = "Revert";
            this.buttonRevert.UseVisualStyleBackColor = false;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
            // 
            // comboBoxLeague
            // 
            this.comboBoxLeague.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.comboBoxLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLeague.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxLeague.FormattingEnabled = true;
            this.comboBoxLeague.Location = new System.Drawing.Point(821, 12);
            this.comboBoxLeague.Name = "comboBoxLeague";
            this.comboBoxLeague.Size = new System.Drawing.Size(178, 21);
            this.comboBoxLeague.TabIndex = 11;
            this.comboBoxLeague.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeague_SelectedIndexChanged);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Location = new System.Drawing.Point(728, 10);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(87, 23);
            this.buttonMenu.TabIndex = 12;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // DraftDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1072, 534);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.comboBoxLeague);
            this.Controls.Add(this.buttonRevert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCurrentTeam);
            this.Controls.Add(this.listBoxMyTeam);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.listBoxRoster);
            this.Controls.Add(this.labelRoundInfo);
            this.Controls.Add(this.listBoxAvailablePlayers);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DraftDay";
            this.Text = "Draft Day";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailablePlayers;
        private System.Windows.Forms.Label labelRoundInfo;
        private System.Windows.Forms.ListBox listBoxRoster;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.ListBox listBoxMyTeam;
        private System.Windows.Forms.Label labelCurrentTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRevert;
        private System.Windows.Forms.ComboBox comboBoxLeague;
        private System.Windows.Forms.Button buttonMenu;
    }
}