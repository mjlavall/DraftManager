namespace DraftManager.Forms
{
    partial class DraftDayLeagueSelect
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
            this.comboBoxLeagues = new System.Windows.Forms.ComboBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLeagues
            // 
            this.comboBoxLeagues.FormattingEnabled = true;
            this.comboBoxLeagues.Location = new System.Drawing.Point(12, 12);
            this.comboBoxLeagues.Name = "comboBoxLeagues";
            this.comboBoxLeagues.Size = new System.Drawing.Size(125, 21);
            this.comboBoxLeagues.TabIndex = 0;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(143, 12);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(38, 23);
            this.buttonGo.TabIndex = 1;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // DraftDayLeagueSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 45);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.comboBoxLeagues);
            this.Name = "DraftDayLeagueSelect";
            this.Text = "DraftDayLeagueSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLeagues;
        private System.Windows.Forms.Button buttonGo;
    }
}