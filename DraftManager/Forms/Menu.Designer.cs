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
            this.SuspendLayout();
            // 
            // buttonLoadPlayers
            // 
            this.buttonLoadPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonLoadPlayers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonLoadPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadPlayers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonLoadPlayers.Location = new System.Drawing.Point(13, 13);
            this.buttonLoadPlayers.Name = "buttonLoadPlayers";
            this.buttonLoadPlayers.Size = new System.Drawing.Size(100, 23);
            this.buttonLoadPlayers.TabIndex = 0;
            this.buttonLoadPlayers.Text = "Load Players";
            this.buttonLoadPlayers.UseVisualStyleBackColor = false;
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
            this.buttonUpdatePlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonUpdatePlayers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonUpdatePlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdatePlayers.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonUpdatePlayers.Location = new System.Drawing.Point(13, 42);
            this.buttonUpdatePlayers.Name = "buttonUpdatePlayers";
            this.buttonUpdatePlayers.Size = new System.Drawing.Size(100, 23);
            this.buttonUpdatePlayers.TabIndex = 2;
            this.buttonUpdatePlayers.Text = "Update Players";
            this.buttonUpdatePlayers.UseVisualStyleBackColor = false;
            this.buttonUpdatePlayers.Click += new System.EventHandler(this.buttonUpdatePlayers_Click);
            // 
            // buttonInjuries
            // 
            this.buttonInjuries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonInjuries.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonInjuries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInjuries.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonInjuries.Location = new System.Drawing.Point(119, 42);
            this.buttonInjuries.Name = "buttonInjuries";
            this.buttonInjuries.Size = new System.Drawing.Size(100, 23);
            this.buttonInjuries.TabIndex = 3;
            this.buttonInjuries.Text = "Mark Injuries";
            this.buttonInjuries.UseVisualStyleBackColor = false;
            this.buttonInjuries.Click += new System.EventHandler(this.buttonInjuries_Click);
            // 
            // buttonNewLeague
            // 
            this.buttonNewLeague.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonNewLeague.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonNewLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewLeague.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonNewLeague.Location = new System.Drawing.Point(13, 71);
            this.buttonNewLeague.Name = "buttonNewLeague";
            this.buttonNewLeague.Size = new System.Drawing.Size(100, 23);
            this.buttonNewLeague.TabIndex = 4;
            this.buttonNewLeague.Text = "New League";
            this.buttonNewLeague.UseVisualStyleBackColor = false;
            this.buttonNewLeague.Click += new System.EventHandler(this.buttonNewLeague_Click);
            // 
            // buttonEditLeague
            // 
            this.buttonEditLeague.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonEditLeague.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.buttonEditLeague.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditLeague.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonEditLeague.Location = new System.Drawing.Point(119, 71);
            this.buttonEditLeague.Name = "buttonEditLeague";
            this.buttonEditLeague.Size = new System.Drawing.Size(100, 23);
            this.buttonEditLeague.TabIndex = 4;
            this.buttonEditLeague.Text = "Edit League";
            this.buttonEditLeague.UseVisualStyleBackColor = false;
            this.buttonEditLeague.Click += new System.EventHandler(this.buttonEditLeague_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(233, 109);
            this.Controls.Add(this.buttonEditLeague);
            this.Controls.Add(this.buttonNewLeague);
            this.Controls.Add(this.buttonInjuries);
            this.Controls.Add(this.buttonUpdatePlayers);
            this.Controls.Add(this.labelLoaded);
            this.Controls.Add(this.buttonLoadPlayers);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
    }
}

