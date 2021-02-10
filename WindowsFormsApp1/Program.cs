using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            // Application.Run(new floorandlight());
            //Application.Run(new mapping_picture());

            // Application.Run(new TextureMappingAndKeyboards());
            // Application.Run(new ColorDialogshow());
            // Application.Run(new simpleopenGLcontrol());
            // Application.Run(new Perspective_othro());

            //Application.Run(new Form19_animetion());
            Application.Run(new Crocodile());
        }
    }
}
