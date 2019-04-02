using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagementProject
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
            // Application.Run(new Home());
            //Application.Run(new Clo());
            //Application.Run(new FrmStudent());
            //Application.Run(new Rubric());
            Application.Run(new StudentAttendance());
        }
    }
}
