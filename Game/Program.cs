using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IntroductionTab());
            
        }
    }
    [Serializable]
    public class question
    {
        string question;
        string correctanswer;
        string answer1;
        string answer2;
        string answer3;
    }

}
