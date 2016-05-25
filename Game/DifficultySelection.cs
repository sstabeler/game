using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class DifficultySelection : Form
    {
        public DifficultySelection()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Game.Properties.Settings.Default.Difficulty = "Easy";
            List<question> easyquestions = new List<question>();
            question newquestion = new question();
            newquestion.actualquestion = "question1";
            newquestion.correctanswer = "correctanswer";
            newquestion.answer1 = "answer1";
            newquestion.answer2 = "answer2";
            newquestion.answer3 = "answer3";
            easyquestions.Add(newquestion);
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                int j = rnd.Next(0, easyquestions.Count);
                datastorage.gamequestions.Push(easyquestions[j]);
            }
            GameInterface easygame = new GameInterface();
            easygame.Show();
        }

        private void btnmedium_Click(object sender, EventArgs e)
        {
            Game.Properties.Settings.Default.Difficulty = "Medium";
            List<question> mediumquestions = new List<question>();
            question newquestion = new question();
            newquestion.actualquestion = "question1";
            newquestion.correctanswer = "correctanswer";
            newquestion.answer1 = "answer1";
            newquestion.answer2 = "answer2";
            newquestion.answer3 = "answer3";
            mediumquestions.Add(newquestion);
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random(mediumquestions.Count);
                int j = rnd.Next();
                datastorage.gamequestions.Push(mediumquestions[j]);
            }
            GameInterface mediumgame = new GameInterface();
            mediumgame.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Game.Properties.Settings.Default.Difficulty = "Hard";
            List<question> hardquestions = new List<question>();
            question newquestion = new question();
            newquestion.actualquestion = "question1";
            newquestion.correctanswer = "correctanswer";
            newquestion.answer1 = "answer1";
            newquestion.answer2 = "answer2";
            newquestion.answer3 = "answer3";
            hardquestions.Add(newquestion);
            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random(hardquestions.Count);
                int j = rnd.Next();
                datastorage.gamequestions.Push(hardquestions[j]);
            }
            GameInterface hardgame = new GameInterface();
            hardgame.Show();
        }
    }
}
