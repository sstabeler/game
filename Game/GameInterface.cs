﻿using System;
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
        public static Stack<question> gamequestions;
        public GameInterface()
        {
            InitializeComponent();
            gamequestions = new Stack<question>();
            switch(Game.Properties.Settings.Default.Difficulty)
            {
                case ("easy"):
                    List<question> easyquestions = new List<question>();
                    question newquestion = new question();
                    newquestion.question = "question1";
                    newquestion.correctanswer = "correctanswer";
                    newquestion.answer1 = "answer1";
                    newquestion.answer2 = "answer2";
                    newquestion.answer3 = "answer3";
                    easyquestions.Add(newquestion);
                    for (int i =0; i < 10; i++)
                    {
                       Random rnd = new Random(easyquestions.Count);
                        int j = rnd.Next();
                        gamequestions.Push(easyquestions[j]);
                    }
                        break;
                case ("medium"):
                    List<question> mediumquestions = new List<question>();
                    newquestion = new question();
                    newquestion.question = "question1";
                    newquestion.correctanswer = "correctanswer";
                    newquestion.answer1 = "answer1";
                    newquestion.answer2 = "answer2";
                    newquestion.answer3 = "answer3";
                    mediumquestions.Add(newquestion);
                    for (int i =0; i < 10; i++)
                     {
                       Random rnd = new Random(mediumquestions.Count);
                        int j = rnd.Next();
                        gamequestions.Push(mediumquestions[j]);
                    }
                    break;
                case("hard"):
                    List<question> hardquestions = new List<question>();
                    newquestion = new question();
                    newquestion.question = "question1";
                    newquestion.correctanswer = "correctanswer";
                    newquestion.answer1 = "answer1";
                    newquestion.answer2 = "answer2";
                    newquestion.answer3 = "answer3";
                    hardquestions.Add(newquestion);
                    for (int i =0; i < 10; i++)
                     {
                       Random rnd = new Random(hardquestions.Count);
                        int j = rnd.Next();
                        gamequestions.Push(hardquestions[j]);
                    }
                    break;
            }

        }
        public static void rungame()
        {
            for (int i=0; i < 10; i++)
            {
                question currentquestion = new question();
                currentquestion = gamequestions.Pop();
            }
        }
    }
}
