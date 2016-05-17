﻿using System;
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
    public partial class GameInterface : Form
    {
        public GameInterface()
        {
            InitializeComponent();
            switch(Game.Properties.Settings.Default.Difficulty)
            {
                case ("easy"):
                    break;
                case ("medium"):
                    break;
                case("hard"):
                    break;
            }
        }
    }
}
