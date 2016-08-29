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
            this.textBoxLeague.Location = new System.Drawing.Point(12, 12);
            this.textBoxLeague.Name = "textBoxLeague";
            this.textBoxLeague.Size = new System.Drawing.Size(192, 20);
            this.textBoxLeague.TabIndex = 0;
            // 
            // buttonAddLeague
            // 
            this.buttonAddLeague.Location = new System.Drawing.Point(12, 38);
            this.buttonAddLeague.Name = "buttonAddLeague";
            this.buttonAddLeague.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLeague.TabIndex = 2;
            this.buttonAddLeague.Text = "Add League";
            this.buttonAddLeague.UseVisualStyleBackColor = true;
            this.buttonAddLeague.Click += new System.EventHandler(this.buttonAddLeague_Click);
            // 
            // listBoxLeagues
            // 
            this.listBoxLeagues.FormattingEnabled = true;
            this.listBoxLeagues.Location = new System.Drawing.Point(12, 67);
            this.listBoxLeagues.Name = "listBoxLeagues";
            this.listBoxLeagues.Size = new System.Drawing.Size(192, 251);
            this.listBoxLeagues.TabIndex = 1;
            // 
            // NewLeague
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 331);
            this.Controls.Add(this.buttonAddLeague);
            this.Controls.Add(this.listBoxLeagues);
            this.Controls.Add(this.textBoxLeague);
            this.Name = "NewLeague";
            this.Text = "DraftSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLeague;
        private System.Windows.Forms.Button buttonAddLeague;
        private System.Windows.Forms.ListBox listBoxLeagues;
    }
}