using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game
{
    public partial class GameInterface : Form
    {
        
        public GameInterface()
        {
            InitializeComponent();
            Game.Properties.Settings.Default.CurrentScore = 40;
            rungame();
        }

        public void rungame()
        {
            if (datastorage.gamequestions.Count > 0 && Game.Properties.Settings.Default.CurrentScore > 0)
            {
                datastorage.currentquestion = datastorage.gamequestions.Pop();
                txtQuestion.Text = datastorage.currentquestion.question;
                rbtnCorrectanswer.Text = datastorage.currentquestion.correctanswer;
                rbtnanswer1.Text = datastorage.currentquestion.answer1;
                rbtnanswer2.Text = datastorage.currentquestion.answer2;
                rbtnanswer3.Text = datastorage.currentquestion.answer3;
            }
            else
            {
                MessageBox.Show("Game Over");
                Game.Properties.Settings.Default.Scores.Add(Game.Properties.Settings.Default.CurrentScore.ToString());
            }
        }

        private void btnAnswer_MouseClick(object sender, MouseEventArgs e)
        {
            if(rbtnCorrectanswer.Checked)
            {
                switch(Game.Properties.Settings.Default.Difficulty)
                {
                    case "Easy":
                        Game.Properties.Settings.Default.CurrentScore += 10;
                        break;
                    case "Medium":
                        Game.Properties.Settings.Default.CurrentScore += 20;
                        break;
                    case "Hard":
                        Game.Properties.Settings.Default.CurrentScore += 30;
                        break;
                }
            }
            else
            {
                switch (Game.Properties.Settings.Default.Difficulty)
                {
                    case "Easy":
                        Game.Properties.Settings.Default.CurrentScore -= 10;
                        break;
                    case "Medium":
                        Game.Properties.Settings.Default.CurrentScore -= 20;
                        break;
                    case "Hard":
                        Game.Properties.Settings.Default.CurrentScore -= 30;
                        break;
                }
            }
            
            
        }
       
    }
}
