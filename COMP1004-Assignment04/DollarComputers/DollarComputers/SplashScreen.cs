//FileName: SplashScreen.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 07/03/2017
//Copy Rights: Junghwan Yang
//Description: This app shows logo of dollar computers for 3.1 seconds
//  

/////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SplashScreen : Form
    {
        //CONSTRUTORS-----------------
        public SplashScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this method setting time and hide splashscreen and show start form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.SplashTimer.Enabled = false;
            this.Hide();
            StartForm start = new StartForm();
            start.Show();

        }
    }
}
