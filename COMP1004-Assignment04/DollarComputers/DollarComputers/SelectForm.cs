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
    
    public partial class SelectForm : Form
    {
        
        ComputersContext ComputerDB = new ComputersContext();

        private Product _selectedRow;

        public Product SelectedRow
        {
            get
            {
                return _selectedRow;
            }
        }
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            //select all the products in the products table of Computer DB
            
            try
            {
                
                var ComputersList = (from product in ComputerDB.products
                                     select product).ToList();
                var SingleComputer = (from product in ComputerDB.products
                                      select product).FirstOrDefault();
                ComputersDataGridView.DataSource = ComputersList;
                ComputersDataGridView.ClearSelection();
                
            } 
            catch ( Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            InitializeSelection();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfo = new ProductInfoForm();
            productInfo.NextButtonEnable();
            this.Hide();
            productInfo.previousForm = this;
            productInfo.SelectedRowData = this.SelectedRow;
            productInfo.SettingTextFromData();
            productInfo.Show();
        }
        
        private void ComputersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in ComputersDataGridView.SelectedRows)
            {
                string manufacturer = row.Cells[2].Value.ToString();
                string model = row.Cells[3].Value.ToString();
                string cost = row.Cells[1].Value.ToString();
                YourSelectionTextBox.Text = manufacturer + ", " + model + ", $" + cost;
            }
            _selectedRow = (Product)ComputersDataGridView.CurrentRow.DataBoundItem;
            NextButton.Enabled = true;
        }

        private void InitializeSelection()
        {
            _selectedRow = new Product();
            NextButton.Enabled = false;
            YourSelectionTextBox.Text = "";
        }
    }
}
