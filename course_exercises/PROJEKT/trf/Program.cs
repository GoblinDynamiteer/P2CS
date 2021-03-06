﻿using System;
using System.Windows.Forms;

namespace trf
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static string name = "TRF - Tigerälskarnas Riksförbund!";
        public static string storedPasswordFile = "login.pwd";
        public static frmPassword passwordWindow;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            passwordWindow = new frmPassword();
            passwordWindow.Show();

            Application.Run();
        }

        public static void QuitProgram()
        {
            Application.Exit();
        }
    }
}
