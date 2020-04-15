using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biljke
{
    static class Program ///svaka klasa nasljeđuje objekt može se napisati i static class Program : object 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] ///sve se komponente crtaju u jednoj dretvi
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new button()); ///pokrece mi registracijsku formu 
        }
    }
}
