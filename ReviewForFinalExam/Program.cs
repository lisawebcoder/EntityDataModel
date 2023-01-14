using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalExam.GUI;
using ReviewForFinalExam.GUI;

namespace FinalExam
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
           //Application.Run(new FormLogIn());
            Application.Run(new entityLoginForm());
            // Application.Run(new FormCourseAssignment());
        }
    }
}
