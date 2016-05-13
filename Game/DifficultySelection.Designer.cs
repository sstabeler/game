namespace Game
{
    partial class DifficultySelection
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
            this.lblDifficultySelection = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnmedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDifficultySelection
            // 
            this.lblDifficultySelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficultySelection.Location = new System.Drawing.Point(328, 99);
            this.lblDifficultySelection.Name = "lblDifficultySelection";
            this.lblDifficultySelection.Size = new System.Drawing.Size(219, 38);
            this.lblDifficultySelection.TabIndex = 0;
            this.lblDifficultySelection.Text = "Difficulty Selection";
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(385, 207);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnmedium
            // 
            this.btnmedium.Location = new System.Drawing.Point(385, 272);
            this.btnmedium.Name = "btnmedium";
            this.btnmedium.Size = new System.Drawing.Size(75, 23);
            this.btnmedium.TabIndex = 2;
            this.btnmedium.Text = "Medium";
            this.btnmedium.UseVisualStyleBackColor = true;
            this.btnmedium.Click += new System.EventHandler(this.btnmedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(385, 331);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 3;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // DifficultySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnmedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblDifficultySelection);
            this.Name = "DifficultySelection";
            this.Text = "DifficultySelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDifficultySelection;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnmedium;
        private System.Windows.Forms.Button btnHard;
    }
}