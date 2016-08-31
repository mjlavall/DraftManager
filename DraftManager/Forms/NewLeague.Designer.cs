namespace DraftManager.Forms
{
    partial class NewLeague
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
            this.textBoxLeague = new System.Windows.Forms.TextBox();
            this.buttonAddLeague = new System.Windows.Forms.Button();
            this.listBoxLeagues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxLeague
            // 
            this.textBoxLeague.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.textBoxLeague.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLeague.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxLeague.Location = new System.Drawing.Point(12, 12);
            this.textBoxLeague.Name = "textBoxLeague";
            this.textBoxLeague.Size = new System.Drawing.Size(192, 20);
            this.textBoxLeague.TabIndex = 0;
            // 
            // buttonAddLeague
            // 
            this.buttonAddLeague.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonAddLeague.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonAddLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLeague.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonAddLeague.Location = new System.Drawing.Point(12, 38);
            this.buttonAddLeague.Name = "buttonAddLeague";
            this.buttonAddLeague.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLeague.TabIndex = 2;
            this.buttonAddLeague.Text = "Add League";
            this.buttonAddLeague.UseVisualStyleBackColor = false;
            this.buttonAddLeague.Click += new System.EventHandler(this.buttonAddLeague_Click);
            // 
            // listBoxLeagues
            // 
            this.listBoxLeagues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.listBoxLeagues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLeagues.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxLeagues.FormattingEnabled = true;
            this.listBoxLeagues.Location = new System.Drawing.Point(12, 67);
            this.listBoxLeagues.Name = "listBoxLeagues";
            this.listBoxLeagues.Size = new System.Drawing.Size(192, 247);
            this.listBoxLeagues.TabIndex = 1;
            // 
            // NewLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(219, 331);
            this.Controls.Add(this.buttonAddLeague);
            this.Controls.Add(this.listBoxLeagues);
            this.Controls.Add(this.textBoxLeague);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewLeague";
            this.Text = "New League";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLeague;
        private System.Windows.Forms.Button buttonAddLeague;
        private System.Windows.Forms.ListBox listBoxLeagues;
    }
}