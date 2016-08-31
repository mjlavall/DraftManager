namespace DraftManager.Forms
{
    partial class UpdatePlayers
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
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownRank = new System.Windows.Forms.NumericUpDown();
            this.checkBoxInjured = new System.Windows.Forms.CheckBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.checkBoxOut = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRank)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.listBoxPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPlayers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.Location = new System.Drawing.Point(12, 39);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(176, 182);
            this.listBoxPlayers.TabIndex = 2;
            this.listBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayers_SelectedIndexChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.textBoxFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFilter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxFilter.Location = new System.Drawing.Point(12, 13);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(176, 20);
            this.textBoxFilter.TabIndex = 1;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.comboBoxTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTeam.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(78, 130);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTeam.TabIndex = 7;
            this.comboBoxTeam.SelectedIndexChanged += new System.EventHandler(this.generic_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Team";
            // 
            // numericUpDownRank
            // 
            this.numericUpDownRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.numericUpDownRank.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.numericUpDownRank.Location = new System.Drawing.Point(78, 22);
            this.numericUpDownRank.Name = "numericUpDownRank";
            this.numericUpDownRank.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownRank.TabIndex = 3;
            this.numericUpDownRank.ValueChanged += new System.EventHandler(this.generic_ValueChanged);
            // 
            // checkBoxInjured
            // 
            this.checkBoxInjured.AutoSize = true;
            this.checkBoxInjured.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.checkBoxInjured.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxInjured.Location = new System.Drawing.Point(78, 157);
            this.checkBoxInjured.Name = "checkBoxInjured";
            this.checkBoxInjured.Size = new System.Drawing.Size(58, 17);
            this.checkBoxInjured.TabIndex = 8;
            this.checkBoxInjured.Text = "Injured";
            this.checkBoxInjured.UseVisualStyleBackColor = false;
            this.checkBoxInjured.CheckedChanged += new System.EventHandler(this.generic_ValueChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxLastName.Location = new System.Drawing.Point(78, 74);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(179, 20);
            this.textBoxLastName.TabIndex = 5;
            this.textBoxLastName.Leave += new System.EventHandler(this.generic_ValueChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxFirstName.Location = new System.Drawing.Point(78, 48);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(179, 20);
            this.textBoxFirstName.TabIndex = 4;
            this.textBoxFirstName.Leave += new System.EventHandler(this.generic_ValueChanged);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.comboBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPosition.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(78, 103);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPosition.TabIndex = 6;
            this.comboBoxPosition.SelectedIndexChanged += new System.EventHandler(this.generic_ValueChanged);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.checkBoxOut);
            this.groupBoxDetails.Controls.Add(this.comboBoxPosition);
            this.groupBoxDetails.Controls.Add(this.textBoxFirstName);
            this.groupBoxDetails.Controls.Add(this.textBoxLastName);
            this.groupBoxDetails.Controls.Add(this.checkBoxInjured);
            this.groupBoxDetails.Controls.Add(this.numericUpDownRank);
            this.groupBoxDetails.Controls.Add(this.label5);
            this.groupBoxDetails.Controls.Add(this.label1);
            this.groupBoxDetails.Controls.Add(this.comboBoxTeam);
            this.groupBoxDetails.Controls.Add(this.label2);
            this.groupBoxDetails.Controls.Add(this.label3);
            this.groupBoxDetails.Controls.Add(this.label4);
            this.groupBoxDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxDetails.Location = new System.Drawing.Point(194, 12);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(284, 213);
            this.groupBoxDetails.TabIndex = 15;
            this.groupBoxDetails.TabStop = false;
            // 
            // checkBoxOut
            // 
            this.checkBoxOut.AutoSize = true;
            this.checkBoxOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.checkBoxOut.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxOut.Location = new System.Drawing.Point(142, 157);
            this.checkBoxOut.Name = "checkBoxOut";
            this.checkBoxOut.Size = new System.Drawing.Size(43, 17);
            this.checkBoxOut.TabIndex = 12;
            this.checkBoxOut.Text = "Out";
            this.checkBoxOut.UseVisualStyleBackColor = false;
            this.checkBoxOut.CheckedChanged += new System.EventHandler(this.generic_ValueChanged);
            // 
            // UpdatePlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(488, 234);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.listBoxPlayers);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdatePlayers";
            this.Text = "Update Players";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRank)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPlayers;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownRank;
        private System.Windows.Forms.CheckBox checkBoxInjured;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.CheckBox checkBoxOut;
    }
}

