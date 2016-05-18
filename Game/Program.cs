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
    [Serializable]
    public class question : ISerializable
    {
        string question;
        string correctanswer;
        string answer1;
        string answer2;
        string answer3;

        //Deserialization constructor.
public question (SerializationInfo info, StreamingContext ctxt)
{
    //Get the values from info and assign them to the appropriate properties
    
    question = (String)info.GetValue("question", typeof(string));
    correctanswer = (String)info.GetValue("correctanswer", typeof(string));
    answer1 = (String)info.GetValue("answer1", typeof(string));
    answer2 = (String)info.GetValue("answer2", typeof(string));
    answer3 = (String)info.GetValue("answer3", typeof(string));
}
        
//Serialization function.
public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
{
    //You can use any custom name for your name-value pair. But make sure you
    // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
    // then you should read the same with "EmployeeId"
    info.AddValue("question", question);
    info.AddValue("correctanswer", correctanswer);
    info.AddValue("answer1", answer1);
    info.AddValue("answer2", answer2);
    info.AddValue("answer3", answer3);
}
    }

}
