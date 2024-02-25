using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStor_SoftwareProject.UI;
using BookStor_SoftwareProject.Domain;
using BookStor_SoftwareProject.DA;
using System.Data.Entity;

namespace BookStor_SoftwareProject
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
            Application.Run(new form1());
        }
    }
}
