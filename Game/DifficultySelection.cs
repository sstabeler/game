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
            GameInterface easygame = new GameInterface();
            easygame.Show();
        }

        private void btnmedium_Click(object sender, EventArgs e)
        {
            Game.Properties.Settings.Default.Difficulty = "Medium";
            GameInterface mediumgame = new GameInterface();
            mediumgame.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Game.Properties.Settings.Default.Difficulty = "Hard";
            GameInterface hardgame = new GameInterface();
            hardgame.Show();
        }
    }
}
