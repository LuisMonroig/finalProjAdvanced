using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Filename: Program.cs
* Author: Ricardo J. Ramirez Santiago
* Description: main program of the pill app
* History:
*           5/10/2020 - File created. RRS
*/

namespace PillIdentifier
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
            Application.Run(new loginForm());
        }
    }
}
