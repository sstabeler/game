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
            switch(Game.Properties.Settings.Default.Difficulty)
            {
                case ("easy"):
                    List<question> easyquestions = new List<question>();
                    using (StreamReader sr = new StreamReader("easyquestions.txt"))
                    { 
                    
                    }
                   
                        break;
                case ("medium"):
                    List<question> mediumquestions = new List<question>();
                    break;
                case("hard"):
                    List<question> hardquestions = new List<question>();
                    break;
            }
        }
    }
}
