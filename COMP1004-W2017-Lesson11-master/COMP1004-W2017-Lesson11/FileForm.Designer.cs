namespace COMP1004_W2017_Lesson11
{
    partial class FileForm
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveFileGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenFileGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenButton = new System.Windows.Forms.Button();
            this.FirstNameOpenTextBox = new System.Windows.Forms.TextBox();
            this.LastNameOpenTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenPersonFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SavePersonFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveFileGroupBox.SuspendLayout();
            this.OpenFileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(17, 48);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(152, 32);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(23, 84);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(462, 38);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(23, 167);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(462, 38);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(17, 131);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(151, 32);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(353, 212);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 58);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // SaveFileGroupBox
            // 
            this.SaveFileGroupBox.Controls.Add(this.FirstNameLabel);
            this.SaveFileGroupBox.Controls.Add(this.SaveButton);
            this.SaveFileGroupBox.Controls.Add(this.FirstNameTextBox);
            this.SaveFileGroupBox.Controls.Add(this.LastNameTextBox);
            this.SaveFileGroupBox.Controls.Add(this.LastNameLabel);
            this.SaveFileGroupBox.Location = new System.Drawing.Point(38, 22);
            this.SaveFileGroupBox.Name = "SaveFileGroupBox";
            this.SaveFileGroupBox.Size = new System.Drawing.Size(524, 283);
            this.SaveFileGroupBox.TabIndex = 5;
            this.SaveFileGroupBox.TabStop = false;
            this.SaveFileGroupBox.Text = "Save File";
            // 
            // OpenFileGroupBox
            // 
            this.OpenFileGroupBox.Controls.Add(this.label1);
            this.OpenFileGroupBox.Controls.Add(this.OpenButton);
            this.OpenFileGroupBox.Controls.Add(this.FirstNameOpenTextBox);
            this.OpenFileGroupBox.Controls.Add(this.LastNameOpenTextBox);
            this.OpenFileGroupBox.Controls.Add(this.label2);
            this.OpenFileGroupBox.Location = new System.Drawing.Point(38, 330);
            this.OpenFileGroupBox.Name = "OpenFileGroupBox";
            this.OpenFileGroupBox.Size = new System.Drawing.Size(524, 283);
            this.OpenFileGroupBox.TabIndex = 6;
            this.OpenFileGroupBox.TabStop = false;
            this.OpenFileGroupBox.Text = "Open File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(353, 212);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(132, 58);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this._openButton_Click);
            // 
            // FirstNameOpenTextBox
            // 
            this.FirstNameOpenTextBox.Location = new System.Drawing.Point(23, 84);
            this.FirstNameOpenTextBox.Name = "FirstNameOpenTextBox";
            this.FirstNameOpenTextBox.Size = new System.Drawing.Size(462, 38);
            this.FirstNameOpenTextBox.TabIndex = 1;
            // 
            // LastNameOpenTextBox
            // 
            this.LastNameOpenTextBox.Location = new System.Drawing.Point(23, 167);
            this.LastNameOpenTextBox.Name = "LastNameOpenTextBox";
            this.LastNameOpenTextBox.Size = new System.Drawing.Size(462, 38);
            this.LastNameOpenTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // FileForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(585, 657);
            this.Controls.Add(this.OpenFileGroupBox);
            this.Controls.Add(this.SaveFileGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileForm";
            this.SaveFileGroupBox.ResumeLayout(false);
            this.SaveFileGroupBox.PerformLayout();
            this.OpenFileGroupBox.ResumeLayout(false);
            this.OpenFileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox SaveFileGroupBox;
        private System.Windows.Forms.GroupBox OpenFileGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.TextBox FirstNameOpenTextBox;
        private System.Windows.Forms.TextBox LastNameOpenTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog OpenPersonFileDialog;
        private System.Windows.Forms.SaveFileDialog SavePersonFileDialog;
    }
}