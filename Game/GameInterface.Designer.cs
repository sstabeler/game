namespace Game
{
    partial class GameInterface
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.rbtnCorrectanswer = new System.Windows.Forms.RadioButton();
            this.rbtnanswer1 = new System.Windows.Forms.RadioButton();
            this.rbtnanswer2 = new System.Windows.Forms.RadioButton();
            this.rbtnanswer3 = new System.Windows.Forms.RadioButton();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(119, 41);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(622, 119);
            this.txtQuestion.TabIndex = 0;
            // 
            // rbtnCorrectanswer
            // 
            this.rbtnCorrectanswer.AutoSize = true;
            this.rbtnCorrectanswer.Location = new System.Drawing.Point(138, 225);
            this.rbtnCorrectanswer.Name = "rbtnCorrectanswer";
            this.rbtnCorrectanswer.Size = new System.Drawing.Size(85, 17);
            this.rbtnCorrectanswer.TabIndex = 1;
            this.rbtnCorrectanswer.TabStop = true;
            this.rbtnCorrectanswer.Text = "radioButton1";
            this.rbtnCorrectanswer.UseVisualStyleBackColor = true;
            // 
            // rbtnanswer1
            // 
            this.rbtnanswer1.AutoSize = true;
            this.rbtnanswer1.Location = new System.Drawing.Point(138, 249);
            this.rbtnanswer1.Name = "rbtnanswer1";
            this.rbtnanswer1.Size = new System.Drawing.Size(85, 17);
            this.rbtnanswer1.TabIndex = 2;
            this.rbtnanswer1.TabStop = true;
            this.rbtnanswer1.Text = "radioButton2";
            this.rbtnanswer1.UseVisualStyleBackColor = true;
            // 
            // rbtnanswer2
            // 
            this.rbtnanswer2.AutoSize = true;
            this.rbtnanswer2.Location = new System.Drawing.Point(138, 273);
            this.rbtnanswer2.Name = "rbtnanswer2";
            this.rbtnanswer2.Size = new System.Drawing.Size(85, 17);
            this.rbtnanswer2.TabIndex = 3;
            this.rbtnanswer2.TabStop = true;
            this.rbtnanswer2.Text = "radioButton3";
            this.rbtnanswer2.UseVisualStyleBackColor = true;
            // 
            // rbtnanswer3
            // 
            this.rbtnanswer3.AutoSize = true;
            this.rbtnanswer3.Location = new System.Drawing.Point(138, 297);
            this.rbtnanswer3.Name = "rbtnanswer3";
            this.rbtnanswer3.Size = new System.Drawing.Size(85, 17);
            this.rbtnanswer3.TabIndex = 4;
            this.rbtnanswer3.TabStop = true;
            this.rbtnanswer3.Text = "radioButton4";
            this.rbtnanswer3.UseVisualStyleBackColor = true;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(321, 377);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnAnswer.TabIndex = 5;
            this.btnAnswer.Text = "Answer Question";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAnswer_MouseClick);
            // 
            // GameInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 623);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.rbtnanswer3);
            this.Controls.Add(this.rbtnanswer2);
            this.Controls.Add(this.rbtnanswer1);
            this.Controls.Add(this.rbtnCorrectanswer);
            this.Controls.Add(this.txtQuestion);
            this.Name = "GameInterface";
            this.Text = "GameInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.RadioButton rbtnCorrectanswer;
        private System.Windows.Forms.RadioButton rbtnanswer1;
        private System.Windows.Forms.RadioButton rbtnanswer2;
        private System.Windows.Forms.RadioButton rbtnanswer3;
        private System.Windows.Forms.Button btnAnswer;
    }
}