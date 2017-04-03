//FileName: ProductInfoForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 07/03/2017
//Copy Rights: Junghwan Yang
//Description: This app shows information of selected product and save that information as txt file or open txt file to load data
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
    public partial class ProductInfoForm : Form
    {
        //PUBLIC CLASS-----------------------
        public SelectForm previousForm;
        //PRIVATE INSTANCE VARIABLES---------------
        private IFormatter _objBinaryFormatter = new BinaryFormatter();
        private Product _selectedRowData;
        
        //CONSTRUCTORS-----------------------------
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        //EVENT HANDELER --------------------------------
        /// <summary>
        /// This method shows Order form when users click the next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickNextButton(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            this.Hide();
            order.previousForm = this;
            order.BringDataFromProductInfoForm();
            order.SettingPictureOnPlatform();
            order.Show();
        }
        /// <summary>
        /// This method shows selectForm when users click selectanotherproductbutton or menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickSelectAnotherProduct(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();    
        }

        /// <summary>
        /// This method terminates app when users click cancel button or menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickCancel(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This method saves information of selected product 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _clickSaveToolStripMenuItem(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;
            SaveProductFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveProductFileDialog.FileName = "Product.txt";
            SaveProductFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            result = SaveProductFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                filename = SaveProductFileDialog.FileName;
                try
                {
                    Stream objStream = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
                    _objBinaryFormatter.Serialize(objStream, _selectedRowData);
                    objStream.Close();
                    MessageBox.Show("File Written Successfully", "File Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    MessageBox.Show("Error Writting File", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //PUBLIC METHODS------------------------
        /// <summary>
        /// 
        /// </summary>
        public void SettingTextFromData()
        {
            ProductIDTextBox.Text = _selectedRowData.productID.ToString();
            CostTextBox.Text = "$" + string.Format("{0:#,##0.00}", _selectedRowData.cost);
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
        }

        /// <summary>
        /// This method opens file when users click the open menu or load a saved file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickOpenToolStripMenuItem(object sender, EventArgs e)
        {
            try
            {
                string filename;
                DialogResult result;
                OpenProductFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
                OpenProductFileDialog.FileName = "";
                OpenProductFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                result = OpenProductFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    filename = OpenProductFileDialog.FileName;
                    Stream objStreamDeSerialize = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
                    _selectedRowData = (Product)_objBinaryFormatter.Deserialize(objStreamDeSerialize);
                    SettingTextFromData();
                    //    MessageBox.Show("File Empty - No data to Read", "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NextButtonEnable();
                    //this._reader.Close();   //flushes the buffer and read the files
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show("Error Reading File", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This method enables next button when the condition is correct
        /// </summary>
        public void NextButtonEnable()
        {
            NextButton.Enabled = true;
        }
        /// <summary>
        /// this method is setter and getter for _selectedRowData
        /// </summary>
        public Product SelectedRowData
        {
            get
            {
                return _selectedRowData;
            }
            set
            {
                this._selectedRowData = value;
            }

        }
    }
}
