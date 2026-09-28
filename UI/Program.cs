using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;

namespace CameraController
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TGMTini.GetInstance().LoadConfig("config.ini", "CameraController");
            TGMTregistry.GetInstance().Init("CameraController");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormMain.GetInstance());
        }
    }
}
