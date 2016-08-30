namespace DraftManager.Forms
{
    partial class MarkInjuries
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
            this.listBoxHealthy = new System.Windows.Forms.ListBox();
            this.listBoxInjured = new System.Windows.Forms.ListBox();
            this.textBoxHealthy = new System.Windows.Forms.TextBox();
            this.textBoxInjured = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxHealthy
            // 
            this.listBoxHealthy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.listBoxHealthy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHealthy.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxHealthy.FormattingEnabled = true;
            this.listBoxHealthy.Location = new System.Drawing.Point(13, 51);
            this.listBoxHealthy.Name = "listBoxHealthy";
            this.listBoxHealthy.Size = new System.Drawing.Size(155, 364);
            this.listBoxHealthy.TabIndex = 4;
            this.listBoxHealthy.DoubleClick += new System.EventHandler(this.listBoxHealthy_DoubleClick);
            // 
            // listBoxInjured
            // 
            this.listBoxInjured.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.listBoxInjured.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxInjured.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBoxInjured.FormattingEnabled = true;
            this.listBoxInjured.Location = new System.Drawing.Point(174, 51);
            this.listBoxInjured.Name = "listBoxInjured";
            this.listBoxInjured.Size = new System.Drawing.Size(155, 364);
            this.listBoxInjured.TabIndex = 5;
            this.listBoxInjured.DoubleClick += new System.EventHandler(this.listBoxInjured_DoubleClick);
            // 
            // textBoxHealthy
            // 
            this.textBoxHealthy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.textBoxHealthy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHealthy.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxHealthy.Location = new System.Drawing.Point(13, 25);
            this.textBoxHealthy.Name = "textBoxHealthy";
            this.textBoxHealthy.Size = new System.Drawing.Size(155, 20);
            this.textBoxHealthy.TabIndex = 6;
            this.textBoxHealthy.TextChanged += new System.EventHandler(this.textBoxHealthy_TextChanged);
            // 
            // textBoxInjured
            // 
            this.textBoxInjured.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.textBoxInjured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInjured.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxInjured.Location = new System.Drawing.Point(174, 25);
            this.textBoxInjured.Name = "textBoxInjured";
            this.textBoxInjured.Size = new System.Drawing.Size(155, 20);
            this.textBoxInjured.TabIndex = 7;
            this.textBoxInjured.TextChanged += new System.EventHandler(this.textBoxInjured_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Healthy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Injured";
            // 
            // MarkInjuries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(341, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInjured);
            this.Controls.Add(this.textBoxHealthy);
            this.Controls.Add(this.listBoxInjured);
            this.Controls.Add(this.listBoxHealthy);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MarkInjuries";
            this.Text = "Mark Injuries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxHealthy;
        private System.Windows.Forms.ListBox listBoxInjured;
        private System.Windows.Forms.TextBox textBoxHealthy;
        private System.Windows.Forms.TextBox textBoxInjured;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}