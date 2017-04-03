//FileName: StartForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 07/03/2017
//Copy Rights: Junghwan Yang
//Description: This app shows selection users can choose load files or select from db to select product
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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;

namespace DollarComputers
{
    public partial class StartForm : Form
    {
        //PRIVATE INSTANCE VARIABLES---------------
        private IFormatter _objBinaryFormatter = new BinaryFormatter();
        private Product _product;
        
        //CONSTRUTORS-------------
        public StartForm()
        {
            InitializeComponent();
            this._product = new Product();
        }
        //EVENT HANDLERS-------------------------
        /// <summary>
        /// this method helps users can select product from db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickStartNewOrderButton(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            this.Hide();
            select.Show();

        }

        /// <summary>
        /// this method terminates app when users click exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickExitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// this method opens files to get data from file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickLoadSavedOrderButton(object sender, EventArgs e)
        {
            ProductInfoForm product = new ProductInfoForm();
            product.Show();
            product.previousForm = new SelectForm();
            this.Hide();
            product.ClickOpenToolStripMenuItem(sender, e);
        }

    }
}
