using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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

    public class datastorage
    {
        public static Stack<question> gamequestions = new Stack<question>();
        public static question currentquestion;

    }
    public class question
    {
        public string actualquestion;
        public string correctanswer;
        public string answer1;
        public string answer2;
        public string answer3;

    }

}

         
