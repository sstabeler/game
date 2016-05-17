namespace Game
{
    partial class IntroductionTab
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
            this.lblMatchFacts = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnProceedToGame = new System.Windows.Forms.Button();
            this.rbnStartGameAutomatically = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblMatchFacts
            // 
            this.lblMatchFacts.AutoSize = true;
            this.lblMatchFacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchFacts.Location = new System.Drawing.Point(176, 85);
            this.lblMatchFacts.Name = "lblMatchFacts";
            this.lblMatchFacts.Size = new System.Drawing.Size(328, 46);
            this.lblMatchFacts.TabIndex = 0;
            this.lblMatchFacts.Text = "Match The Facts:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(164, 176);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(400, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(53, 182);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Username:";
            // 
            // btnProceedToGame
            // 
            this.btnProceedToGame.Location = new System.Drawing.Point(202, 254);
            this.btnProceedToGame.Name = "btnProceedToGame";
            this.btnProceedToGame.Size = new System.Drawing.Size(144, 23);
            this.btnProceedToGame.TabIndex = 3;
            this.btnProceedToGame.Text = "Proceed To Game";
            this.btnProceedToGame.UseVisualStyleBackColor = true;
            this.btnProceedToGame.Click += new System.EventHandler(this.btnProceedToGame_Click);
            // 
            // rbnStartGameAutomatically
            // 
            this.rbnStartGameAutomatically.AutoSize = true;
            this.rbnStartGameAutomatically.Location = new System.Drawing.Point(236, 366);
            this.rbnStartGameAutomatically.Name = "rbnStartGameAutomatically";
            this.rbnStartGameAutomatically.Size = new System.Drawing.Size(143, 17);
            this.rbnStartGameAutomatically.TabIndex = 4;
            this.rbnStartGameAutomatically.TabStop = true;
            this.rbnStartGameAutomatically.Text = "Start Game Automatically";
            this.rbnStartGameAutomatically.UseVisualStyleBackColor = true;
            // 
            // IntroductionTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 601);
            this.Controls.Add(this.rbnStartGameAutomatically);
            this.Controls.Add(this.btnProceedToGame);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblMatchFacts);
            this.Name = "IntroductionTab";
            this.Text = "Introduction Tab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatchFacts;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnProceedToGame;
        private System.Windows.Forms.RadioButton rbnStartGameAutomatically;
    }
}

