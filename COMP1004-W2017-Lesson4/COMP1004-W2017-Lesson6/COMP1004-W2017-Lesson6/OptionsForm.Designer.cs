namespace COMP1004_W2017_Lesson6
{
    partial class OptionsForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FunctiionGroupBox = new System.Windows.Forms.GroupBox();
            this.ExponentCheckBox = new System.Windows.Forms.CheckBox();
            this.SquareRootCheckBox = new System.Windows.Forms.CheckBox();
            this.LayoutGroupBox = new System.Windows.Forms.GroupBox();
            this.ScientificRadioButton = new System.Windows.Forms.RadioButton();
            this.StandardRadioButton = new System.Windows.Forms.RadioButton();
            this.FontButton = new System.Windows.Forms.Button();
            this.CalculatorFontDialog = new System.Windows.Forms.FontDialog();
            this.FunctiionGroupBox.SuspendLayout();
            this.LayoutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(12, 308);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(148, 58);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this._acceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(324, 308);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(148, 58);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this._cancelButton_Click);
            // 
            // FunctiionGroupBox
            // 
            this.FunctiionGroupBox.Controls.Add(this.ExponentCheckBox);
            this.FunctiionGroupBox.Controls.Add(this.SquareRootCheckBox);
            this.FunctiionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FunctiionGroupBox.Location = new System.Drawing.Point(30, 25);
            this.FunctiionGroupBox.Name = "FunctiionGroupBox";
            this.FunctiionGroupBox.Size = new System.Drawing.Size(182, 135);
            this.FunctiionGroupBox.TabIndex = 2;
            this.FunctiionGroupBox.TabStop = false;
            this.FunctiionGroupBox.Text = "Functions";
            // 
            // ExponentCheckBox
            // 
            this.ExponentCheckBox.AutoSize = true;
            this.ExponentCheckBox.Location = new System.Drawing.Point(6, 83);
            this.ExponentCheckBox.Name = "ExponentCheckBox";
            this.ExponentCheckBox.Size = new System.Drawing.Size(136, 33);
            this.ExponentCheckBox.TabIndex = 1;
            this.ExponentCheckBox.Text = "Exponent";
            this.ExponentCheckBox.UseVisualStyleBackColor = true;
            // 
            // SquareRootCheckBox
            // 
            this.SquareRootCheckBox.AutoSize = true;
            this.SquareRootCheckBox.Location = new System.Drawing.Point(6, 44);
            this.SquareRootCheckBox.Name = "SquareRootCheckBox";
            this.SquareRootCheckBox.Size = new System.Drawing.Size(170, 33);
            this.SquareRootCheckBox.TabIndex = 0;
            this.SquareRootCheckBox.Text = "Square Root";
            this.SquareRootCheckBox.UseVisualStyleBackColor = true;
            // 
            // LayoutGroupBox
            // 
            this.LayoutGroupBox.Controls.Add(this.ScientificRadioButton);
            this.LayoutGroupBox.Controls.Add(this.StandardRadioButton);
            this.LayoutGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutGroupBox.Location = new System.Drawing.Point(276, 25);
            this.LayoutGroupBox.Name = "LayoutGroupBox";
            this.LayoutGroupBox.Size = new System.Drawing.Size(182, 135);
            this.LayoutGroupBox.TabIndex = 3;
            this.LayoutGroupBox.TabStop = false;
            this.LayoutGroupBox.Text = "Layout";
            // 
            // ScientificRadioButton
            // 
            this.ScientificRadioButton.AutoSize = true;
            this.ScientificRadioButton.Location = new System.Drawing.Point(7, 83);
            this.ScientificRadioButton.Name = "ScientificRadioButton";
            this.ScientificRadioButton.Size = new System.Drawing.Size(131, 33);
            this.ScientificRadioButton.TabIndex = 1;
            this.ScientificRadioButton.Text = "Scientific";
            this.ScientificRadioButton.UseVisualStyleBackColor = true;
            this.ScientificRadioButton.CheckedChanged += new System.EventHandler(this._calculatorLayoutRadioButton_CheckedChanged);
            // 
            // StandardRadioButton
            // 
            this.StandardRadioButton.AutoSize = true;
            this.StandardRadioButton.Checked = true;
            this.StandardRadioButton.Location = new System.Drawing.Point(7, 44);
            this.StandardRadioButton.Name = "StandardRadioButton";
            this.StandardRadioButton.Size = new System.Drawing.Size(131, 33);
            this.StandardRadioButton.TabIndex = 0;
            this.StandardRadioButton.TabStop = true;
            this.StandardRadioButton.Text = "Standard";
            this.StandardRadioButton.UseVisualStyleBackColor = true;
            this.StandardRadioButton.CheckedChanged += new System.EventHandler(this._calculatorLayoutRadioButton_CheckedChanged);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(12, 202);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(148, 58);
            this.FontButton.TabIndex = 4;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this._fontButton_Click);
            // 
            // CalculatorFontDialog
            // 
            this.CalculatorFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculatorFontDialog.MaxSize = 24;
            this.CalculatorFontDialog.MinSize = 10;
            // 
            // OptionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 378);
            this.ControlBox = false;
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.LayoutGroupBox);
            this.Controls.Add(this.FunctiionGroupBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsForm";
            this.FunctiionGroupBox.ResumeLayout(false);
            this.FunctiionGroupBox.PerformLayout();
            this.LayoutGroupBox.ResumeLayout(false);
            this.LayoutGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox FunctiionGroupBox;
        private System.Windows.Forms.CheckBox ExponentCheckBox;
        private System.Windows.Forms.CheckBox SquareRootCheckBox;
        private System.Windows.Forms.GroupBox LayoutGroupBox;
        private System.Windows.Forms.RadioButton ScientificRadioButton;
        private System.Windows.Forms.RadioButton StandardRadioButton;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.FontDialog CalculatorFontDialog;
    }
}