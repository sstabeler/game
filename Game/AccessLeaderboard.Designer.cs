namespace Game
{
    partial class AccessLeaderboard
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
            this.gbxIndividualHighscores = new System.Windows.Forms.GroupBox();
            this.gbxOverallHighScores = new System.Windows.Forms.GroupBox();
            this.txtOverallHighscores = new System.Windows.Forms.TextBox();
            this.txtIndividualHighscores = new System.Windows.Forms.TextBox();
            this.gbxIndividualHighscores.SuspendLayout();
            this.gbxOverallHighScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIndividualHighscores
            // 
            this.gbxIndividualHighscores.Controls.Add(this.txtIndividualHighscores);
            this.gbxIndividualHighscores.Location = new System.Drawing.Point(70, 45);
            this.gbxIndividualHighscores.Name = "gbxIndividualHighscores";
            this.gbxIndividualHighscores.Size = new System.Drawing.Size(386, 333);
            this.gbxIndividualHighscores.TabIndex = 0;
            this.gbxIndividualHighscores.TabStop = false;
            this.gbxIndividualHighscores.Text = "Individual";
            // 
            // gbxOverallHighScores
            // 
            this.gbxOverallHighScores.Controls.Add(this.txtOverallHighscores);
            this.gbxOverallHighScores.Location = new System.Drawing.Point(481, 45);
            this.gbxOverallHighScores.Name = "gbxOverallHighScores";
            this.gbxOverallHighScores.Size = new System.Drawing.Size(473, 333);
            this.gbxOverallHighScores.TabIndex = 1;
            this.gbxOverallHighScores.TabStop = false;
            this.gbxOverallHighScores.Text = "Overall";
            // 
            // txtOverallHighscores
            // 
            this.txtOverallHighscores.Location = new System.Drawing.Point(7, 20);
            this.txtOverallHighscores.Multiline = true;
            this.txtOverallHighscores.Name = "txtOverallHighscores";
            this.txtOverallHighscores.ReadOnly = true;
            this.txtOverallHighscores.Size = new System.Drawing.Size(445, 307);
            this.txtOverallHighscores.TabIndex = 0;
            // 
            // txtIndividualHighscores
            // 
            this.txtIndividualHighscores.Location = new System.Drawing.Point(7, 20);
            this.txtIndividualHighscores.Multiline = true;
            this.txtIndividualHighscores.Name = "txtIndividualHighscores";
            this.txtIndividualHighscores.ReadOnly = true;
            this.txtIndividualHighscores.Size = new System.Drawing.Size(373, 307);
            this.txtIndividualHighscores.TabIndex = 0;
            // 
            // AccessLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 634);
            this.Controls.Add(this.gbxOverallHighScores);
            this.Controls.Add(this.gbxIndividualHighscores);
            this.Name = "AccessLeaderboard";
            this.Text = "AccessLeaderboard";
            this.Load += new System.EventHandler(this.AccessLeaderboard_Load);
            this.gbxIndividualHighscores.ResumeLayout(false);
            this.gbxIndividualHighscores.PerformLayout();
            this.gbxOverallHighScores.ResumeLayout(false);
            this.gbxOverallHighScores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIndividualHighscores;
        private System.Windows.Forms.TextBox txtIndividualHighscores;
        private System.Windows.Forms.GroupBox gbxOverallHighScores;
        private System.Windows.Forms.TextBox txtOverallHighscores;
    }
}