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
    public partial class AccessLeaderboard : Form
    {
        public AccessLeaderboard()
        {
            InitializeComponent();
        }

        private void AccessLeaderboard_Load(object sender, EventArgs e)
        {
            for (int i=0; i< Game.Properties.Settings.Default.Scores.Count; i++ )
            {
                txtIndividualHighscores.AppendText(Game.Properties.Settings.Default.Scores[i].ToString());
            }
            for(int i=0; i< Game.Properties.Settings.Default.Highscores.Count; i++)
            {
                txtOverallHighscores.AppendText(Game.Properties.Settings.Default.Highscores[i].ToString());
            }
        }
    }
}
