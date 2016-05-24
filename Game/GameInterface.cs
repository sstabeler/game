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
            rungame();
        }

        public void rungame()
        {
            datastorage.currentquestion = datastorage.gamequestions.Pop();
            txtQuestion.Text = datastorage.currentquestion.question;
            rbtnCorrectanswer.Text = datastorage.currentquestion.correctanswer;
            rbtnanswer1.Text = datastorage.currentquestion.answer1;
            rbtnanswer2.Text = datastorage.currentquestion.answer2;
            rbtnanswer3.Text = datastorage.currentquestion.answer3;
        }

        private void btnAnswer_MouseClick(object sender, MouseEventArgs e)
        {
            if(rbtnCorrectanswer.Checked)
            {

            }
        }
       
    }
}
