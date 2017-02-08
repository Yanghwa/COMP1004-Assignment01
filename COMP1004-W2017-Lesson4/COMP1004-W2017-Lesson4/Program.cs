﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson4
{
    public static class Program
    {
        // declared public static Form - Application GLOBAL
        public static SplashForm MySplashForm;

        // declared public static Form - Calculator Form
        public static CalculatorForm MyCalculatorForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize SplashForm and CalculatorForm
            Program.MySplashForm = new SplashForm();
            Program.MyCalculatorForm = new CalculatorForm();

            Application.Run(Program.MySplashForm);
        }
    }
}
