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
using System.Diagnostics;

namespace COMP1004_W2017_Lesson11
{
    public partial class FileForm : Form
    {
        private StreamWriter _writer;
        private StreamReader _reader;
        private const char _DELIMETER = ',';
        private Person _person;

        public FileForm()
        {
            InitializeComponent();

            this._person = new Person();

        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;

            SavePersonFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            SavePersonFileDialog.FileName = "person.txt";
            SavePersonFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            result = SavePersonFileDialog.ShowDialog();

            if(result == DialogResult.OK) {

                filename = SavePersonFileDialog.FileName;
            
            try
            {
                this._writer = new StreamWriter(filename, true);
                this._writer.Write(FirstNameTextBox.Text);
                this._writer.Write(_DELIMETER);
                this._writer.WriteLine(LastNameTextBox.Text);
                this._writer.Close(); // flushes the buffer and writes to the file

                MessageBox.Show("File Written Successfully", "File Status", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                FirstNameTextBox.Focus();
            }
            catch (Exception exception)
            {
                
                Debug.WriteLine(exception.Message);
                MessageBox.Show("Error  Writing File", "File Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        }

        private void _openButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;

            OpenPersonFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            OpenPersonFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            result = OpenPersonFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                filename = OpenPersonFileDialog.FileName;
            

            string fullNameString = "";

            try
            {
                this._reader = new StreamReader(filename);

                // check if we haven't arrived at end of file (EOF)
                if(this._reader.Peek() != -1)
                {
                    fullNameString = this._reader.ReadLine();

                    this._person.FirstName = fullNameString.Split(_DELIMETER)[0]; // first name
                    this._person.LastName = fullNameString.Split(_DELIMETER)[1]; // last name

                    FirstNameOpenTextBox.Text = this._person.FirstName;
                    LastNameOpenTextBox.Text = this._person.LastName;
                }
                else
                {
                    MessageBox.Show("File Empty - No data to Read", "Error Reading File", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this._reader.Close();
            }
            catch (Exception exception)
            {

                Debug.WriteLine(exception.Message);
                MessageBox.Show("Error  Reading File", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
    }
}
