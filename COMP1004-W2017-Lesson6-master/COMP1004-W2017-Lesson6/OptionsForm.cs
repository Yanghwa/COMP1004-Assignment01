using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_Lesson6
{
    /// <summary>
    /// OptionsForm controls all the options for the Calculator Form
    /// </summary>
    public partial class OptionsForm : Form
    {

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++
        public OptionsForm()
        {
            InitializeComponent();
        }

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++

        public string CalculatorLayout { get; set; }

        public bool IsSquareRootActive { get; set; }

        public bool IsExponentActive { get; set; }

        public CalculatorForm PreviousForm { get; set; } // reference to previous form ("Calculator Form")


        // PRIVATE METHODS ===============================================

        // EVENT HANDLERS +++++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// CancelButton_Click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// AcceptButton_Click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _acceptButton_Click(object sender, EventArgs e)
        {
            this.PreviousForm.CalculatorFormLayout = this.CalculatorLayout;
            this.Close();
        }

        /// <summary>
        /// FontButton_Click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _fontButton_Click(object sender, EventArgs e)
        {
            // Step 2. Show Dialog
            CalculatorFontDialog.ShowDialog();
        }

        private void _calculatorLayoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton calculatorRadioButton = sender as RadioButton;
            this.CalculatorLayout = calculatorRadioButton.Text;
            Debug.WriteLine(this.CalculatorLayout);
        }
    }
}
