namespace DollarComputers
{
    partial class StartForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.StartNewOrderButton = new System.Windows.Forms.Button();
            this.LoadSavedOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DollorComputersPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenProductFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DollorComputersPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Location = new System.Drawing.Point(96, 18);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(379, 32);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Order Your Computer Today!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartNewOrderButton
            // 
            this.StartNewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StartNewOrderButton.Location = new System.Drawing.Point(155, 282);
            this.StartNewOrderButton.Name = "StartNewOrderButton";
            this.StartNewOrderButton.Size = new System.Drawing.Size(260, 53);
            this.StartNewOrderButton.TabIndex = 1;
            this.StartNewOrderButton.Text = "Start a New Order";
            this.StartNewOrderButton.UseVisualStyleBackColor = true;
            this.StartNewOrderButton.Click += new System.EventHandler(this._clickStartNewOrderButton);
            // 
            // LoadSavedOrderButton
            // 
            this.LoadSavedOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoadSavedOrderButton.Location = new System.Drawing.Point(155, 341);
            this.LoadSavedOrderButton.Name = "LoadSavedOrderButton";
            this.LoadSavedOrderButton.Size = new System.Drawing.Size(260, 53);
            this.LoadSavedOrderButton.TabIndex = 2;
            this.LoadSavedOrderButton.Text = "Load a Saved Order";
            this.LoadSavedOrderButton.UseVisualStyleBackColor = true;
            this.LoadSavedOrderButton.Click += new System.EventHandler(this._clickLoadSavedOrderButton);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExitButton.Location = new System.Drawing.Point(155, 400);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(260, 53);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit the Program";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this._clickExitButton);
            // 
            // DollorComputersPictureBox
            // 
            this.DollorComputersPictureBox.Image = global::DollarComputers.Properties.Resources.laptopImage;
            this.DollorComputersPictureBox.Location = new System.Drawing.Point(155, 70);
            this.DollorComputersPictureBox.Name = "DollorComputersPictureBox";
            this.DollorComputersPictureBox.Size = new System.Drawing.Size(260, 195);
            this.DollorComputersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DollorComputersPictureBox.TabIndex = 4;
            this.DollorComputersPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(575, 456);
            this.ControlBox = false;
            this.Controls.Add(this.DollorComputersPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadSavedOrderButton);
            this.Controls.Add(this.StartNewOrderButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computers!";
            ((System.ComponentModel.ISupportInitialize)(this.DollorComputersPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button StartNewOrderButton;
        private System.Windows.Forms.Button LoadSavedOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox DollorComputersPictureBox;
        private System.Windows.Forms.OpenFileDialog OpenProductFileDialog;
    }
}