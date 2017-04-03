namespace DollarComputers
{
    partial class SelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DollarComputersListLabel = new System.Windows.Forms.Label();
            this.ComputersDataGridView = new System.Windows.Forms.DataGridView();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.YourSelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComputersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DollarComputersListLabel
            // 
            this.DollarComputersListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DollarComputersListLabel.Location = new System.Drawing.Point(30, 13);
            this.DollarComputersListLabel.Name = "DollarComputersListLabel";
            this.DollarComputersListLabel.Size = new System.Drawing.Size(420, 40);
            this.DollarComputersListLabel.TabIndex = 0;
            this.DollarComputersListLabel.Text = "DollarComputers Hardware List ";
            // 
            // ComputersDataGridView
            // 
            this.ComputersDataGridView.AllowUserToAddRows = false;
            this.ComputersDataGridView.AllowUserToDeleteRows = false;
            this.ComputersDataGridView.AllowUserToOrderColumns = true;
            this.ComputersDataGridView.AllowUserToResizeColumns = false;
            this.ComputersDataGridView.AllowUserToResizeRows = false;
            this.ComputersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComputersDataGridView.Location = new System.Drawing.Point(31, 66);
            this.ComputersDataGridView.MultiSelect = false;
            this.ComputersDataGridView.Name = "ComputersDataGridView";
            this.ComputersDataGridView.ReadOnly = true;
            this.ComputersDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ComputersDataGridView.RowTemplate.Height = 28;
            this.ComputersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComputersDataGridView.Size = new System.Drawing.Size(800, 500);
            this.ComputersDataGridView.TabIndex = 1;
            this.ComputersDataGridView.SelectionChanged += new System.EventHandler(this.ComputersDataGridView_SelectionChanged);
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourSelectionLabel.Location = new System.Drawing.Point(30, 580);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(182, 40);
            this.YourSelectionLabel.TabIndex = 2;
            this.YourSelectionLabel.Text = "Your Selection";
            // 
            // YourSelectionTextBox
            // 
            this.YourSelectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.YourSelectionTextBox.Location = new System.Drawing.Point(203, 580);
            this.YourSelectionTextBox.Name = "YourSelectionTextBox";
            this.YourSelectionTextBox.ReadOnly = true;
            this.YourSelectionTextBox.Size = new System.Drawing.Size(412, 35);
            this.YourSelectionTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(645, 580);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 35);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(744, 580);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(87, 35);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(879, 643);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.YourSelectionTextBox);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.ComputersDataGridView);
            this.Controls.Add(this.DollarComputersListLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComputersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DollarComputersListLabel;
        private System.Windows.Forms.DataGridView ComputersDataGridView;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.TextBox YourSelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}