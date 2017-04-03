//FileName: OrderForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 07/03/2017
//Copy Rights: Junghwan Yang
//Description: This app shows the information of selected product, and calculate the total cost
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
    public partial class OrderForm : Form
    {
        //PUBLIC CLASS-----------------------
        public ProductInfoForm previousForm;
        //PRIVATE INSTANCE VARIABLES---------------
        private Product _selectedRowData;
        //CONSTRUCTORS-----------------------------
        public OrderForm()
        {
            InitializeComponent();
        }

        //EVENT HANDELER --------------------------------
        /// <summary>
        /// This method terminates app when users click the cancelbutton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickCancelButton(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        /// <summary>
        /// This method calculates total and sales cost
        /// </summary>
        private void CalculateTotalPrice()
        {
            decimal price = (decimal)_selectedRowData.cost;
            decimal salesTax = price * (decimal)0.13;
            decimal total = price + salesTax;
            SalesTaxTextBox.Text = "$" + string.Format("{0:#,##0.00}", salesTax);
            TotalTextBox.Text = "$" + string.Format("{0:#,##0.00}", total);
        }

        /// <summary>
        /// This method goes back to previous form when users click the back button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickBackButton(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }
        
        /// <summary>
        /// This method shows aboutbox when users click about menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickAboutToolStripMenuItem(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        /// <summary>
        /// This method shows printing information when users click print menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickPrintToolStripMenuItem(object sender, EventArgs e)
        {
            /*MessageBox.Show("Your Selection-----------------\n" 
                + "Condition: " + ConditionTextBox.Text + "\n"
                + "Platform: " + PlatformTextBox.Text + "\n"
                + "Manufacturer: " + ManufacturerTextBox.Text + "\n"    
                + "Model: " + ModelTextBox.Text + "\n"
                + "LCD Size: " + LCDSizeTextBox.Text + "\n"
                + "Memory: " + MemoryTextBox.Text + "\n"
                + "CPU Brand: " + CPUBrandTextBox.Text + "\n"
                + "CPU Type: " + CPUTypeTextBox.Text + "\n"
                + "CPU Number: " + CPUNumberTextBox.Text + "\n"
                + "CPU Speed: " + CPUSpeedTextBox.Text + "\n"
                + "HDD: " + HDDTextBox.Text + "\n"
                + "GPU Type: " + GPUTypeTextBox.Text + "\n"
                + "WebCam: " + WebCamTextBox.Text + "\n"
                + "OS: " + OSTextBox.Text + "\n"
                + "Price: " + PriceTextBox.Text + "\n"
                + "SalesTax: " + SalesTaxTextBox.Text + "\n"
                + "Total Price: " + TotalTextBox.Text + "\n",
             "Selected Computer");*/
            MessageBox.Show("Your Selection is being printed now.\n Thank you for using.");

        }

        /// <summary>
        /// This method shows complete message when users click finish button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickFinishButton(object sender, EventArgs e)
        {
            DialogResult completeOrderResult = MessageBox.Show("Thank you so much for your order! \n\n Your order will be processed in 7-10 business days!",
             "Complete your order!", MessageBoxButtons.OK);
            if(completeOrderResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// This method sets the image depending on computer's platform
        /// </summary>
        public void SettingPictureOnPlatform()
        {
            switch(_selectedRowData.platform)
            {
                case "Laptop":
                    ComputerPictureBox.Image = Properties.Resources.laptop;
                    break;
                case "Desktop PC":
                    ComputerPictureBox.Image = Properties.Resources.desktop;
                    break;
                default:
                    ComputerPictureBox.Image = Properties.Resources.defaultComputer;
                    break;
            }
        }
        //PUBLIC METHODS------------------------
        /// <summary>
        /// This method brings data from previousForm - productinfo form
        /// </summary>
        public void BringDataFromProductInfoForm()
        {
            _selectedRowData = previousForm.SelectedRowData;
            PriceTextBox.Text = "$" + string.Format("{0:#,##0.00}", _selectedRowData.cost);
            ManufacturerTextBox.Text = _selectedRowData.manufacturer.ToString();
            ModelTextBox.Text = _selectedRowData.model.ToString();
            MemoryTextBox.Text = _selectedRowData.RAM_size.ToString();
            LCDSizeTextBox.Text = _selectedRowData.screensize.ToString();
            CPUBrandTextBox.Text = _selectedRowData.CPU_brand.ToString();
            CPUTypeTextBox.Text = _selectedRowData.CPU_type.ToString();
            CPUSpeedTextBox.Text = _selectedRowData.CPU_speed.ToString();
            CPUNumberTextBox.Text = _selectedRowData.CPU_number.ToString();
            ConditionTextBox.Text = _selectedRowData.condition.ToString();
            OSTextBox.Text = _selectedRowData.OS.ToString();
            PlatformTextBox.Text = _selectedRowData.platform.ToString();
            HDDTextBox.Text = _selectedRowData.HDD_size.ToString();
            GPUTypeTextBox.Text = _selectedRowData.GPU_Type.ToString();
            WebCamTextBox.Text = _selectedRowData.webcam.ToString();
            CalculateTotalPrice();
        }
    }
}
