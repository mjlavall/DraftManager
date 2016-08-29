namespace DraftManager.Forms
{
    partial class Menu
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
            this.buttonLoadPlayers = new System.Windows.Forms.Button();
            this.labelLoaded = new System.Windows.Forms.Label();
            this.buttonUpdatePlayers = new System.Windows.Forms.Button();
            this.buttonInjuries = new System.Windows.Forms.Button();
            this.buttonNewLeague = new System.Windows.Forms.Button();
            this.buttonEditLeague = new System.Windows.Forms.Button();
            this.buttonDraftDay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadPlayers
            // 
            this.buttonLoadPlayers.Location = new System.Drawing.Point(13, 13);
            this.buttonLoadPlayers.Name = "buttonLoadPlayers";
            this.buttonLoadPlayers.Size = new System.Drawing.Size(100, 23);
            this.buttonLoadPlayers.TabIndex = 0;
            this.buttonLoadPlayers.Text = "Load Players";
            this.buttonLoadPlayers.UseVisualStyleBackColor = true;
            this.buttonLoadPlayers.Click += new System.EventHandler(this.buttonLoadPlayers_Click);
            // 
            // labelLoaded
            // 
            this.labelLoaded.AutoSize = true;
            this.labelLoaded.Location = new System.Drawing.Point(119, 18);
            this.labelLoaded.Name = "labelLoaded";
            this.labelLoaded.Size = new System.Drawing.Size(46, 13);
            this.labelLoaded.TabIndex = 1;
            this.labelLoaded.Text = "Loaded:";
            // 
            // buttonUpdatePlayers
            // 
            this.buttonUpdatePlayers.Location = new System.Drawing.Point(13, 42);
            this.buttonUpdatePlayers.Name = "buttonUpdatePlayers";
            this.buttonUpdatePlayers.Size = new System.Drawing.Size(100, 23);
            this.buttonUpdatePlayers.TabIndex = 2;
            this.buttonUpdatePlayers.Text = "Update Players";
            this.buttonUpdatePlayers.UseVisualStyleBackColor = true;
            this.buttonUpdatePlayers.Click += new System.EventHandler(this.buttonUpdatePlayers_Click);
            // 
            // buttonInjuries
            // 
            this.buttonInjuries.Location = new System.Drawing.Point(119, 42);
            this.buttonInjuries.Name = "buttonInjuries";
            this.buttonInjuries.Size = new System.Drawing.Size(100, 23);
            this.buttonInjuries.TabIndex = 3;
            this.buttonInjuries.Text = "Mark Injuries";
            this.buttonInjuries.UseVisualStyleBackColor = true;
            this.buttonInjuries.Click += new System.EventHandler(this.buttonInjuries_Click);
            // 
            // buttonNewLeague
            // 
            this.buttonNewLeague.Location = new System.Drawing.Point(13, 71);
            this.buttonNewLeague.Name = "buttonNewLeague";
            this.buttonNewLeague.Size = new System.Drawing.Size(100, 23);
            this.buttonNewLeague.TabIndex = 4;
            this.buttonNewLeague.Text = "New League";
            this.buttonNewLeague.UseVisualStyleBackColor = true;
            this.buttonNewLeague.Click += new System.EventHandler(this.buttonNewLeague_Click);
            // 
            // buttonEditLeague
            // 
            this.buttonEditLeague.Location = new System.Drawing.Point(119, 71);
            this.buttonEditLeague.Name = "buttonEditLeague";
            this.buttonEditLeague.Size = new System.Drawing.Size(100, 23);
            this.buttonEditLeague.TabIndex = 4;
            this.buttonEditLeague.Text = "Edit League";
            this.buttonEditLeague.UseVisualStyleBackColor = true;
            this.buttonEditLeague.Click += new System.EventHandler(this.buttonEditLeague_Click);
            // 
            // buttonDraftDay
            // 
            this.buttonDraftDay.Location = new System.Drawing.Point(65, 100);
            this.buttonDraftDay.Name = "buttonDraftDay";
            this.buttonDraftDay.Size = new System.Drawing.Size(100, 23);
            this.buttonDraftDay.TabIndex = 5;
            this.buttonDraftDay.Text = "Draft Day";
            this.buttonDraftDay.UseVisualStyleBackColor = true;
            this.buttonDraftDay.Click += new System.EventHandler(this.buttonDraftDay_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 130);
            this.Controls.Add(this.buttonDraftDay);
            this.Controls.Add(this.buttonEditLeague);
            this.Controls.Add(this.buttonNewLeague);
            this.Controls.Add(this.buttonInjuries);
            this.Controls.Add(this.buttonUpdatePlayers);
            this.Controls.Add(this.labelLoaded);
            this.Controls.Add(this.buttonLoadPlayers);
            this.Name = "Menu";
            this.Text = "Draft Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadPlayers;
        private System.Windows.Forms.Label labelLoaded;
        private System.Windows.Forms.Button buttonUpdatePlayers;
        private System.Windows.Forms.Button buttonInjuries;
        private System.Windows.Forms.Button buttonNewLeague;
        private System.Windows.Forms.Button buttonEditLeague;
        private System.Windows.Forms.Button buttonDraftDay;
    }
}

