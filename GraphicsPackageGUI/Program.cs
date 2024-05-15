﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsPackageGUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GraphicsPackage_Form());
        }
    }

}


