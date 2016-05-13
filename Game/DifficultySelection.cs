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
        }

        private void btnmedium_Click(object sender, EventArgs e)
        {
            Game.Properties.Settings.Default.Difficulty = "Medium";
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Game.Properties.Settings.Default.Difficulty = "Hard";
        }

        private void startgame()
        {

        }
    }
}
