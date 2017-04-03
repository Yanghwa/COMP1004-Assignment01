namespace COMP1004_W2017_Lesson6
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.MSHLabel = new System.Windows.Forms.Label();
            this.SplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.CharacerGeneratorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MSHLabel
            // 
            this.MSHLabel.AutoSize = true;
            this.MSHLabel.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold);
            this.MSHLabel.ForeColor = System.Drawing.Color.White;
            this.MSHLabel.Location = new System.Drawing.Point(71, 84);
            this.MSHLabel.Name = "MSHLabel";
            this.MSHLabel.Size = new System.Drawing.Size(669, 68);
            this.MSHLabel.TabIndex = 0;
            this.MSHLabel.Text = "Marvel Super Heroes";
            this.MSHLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // CharacerGeneratorLabel
            // 
            this.CharacerGeneratorLabel.AutoSize = true;
            this.CharacerGeneratorLabel.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacerGeneratorLabel.ForeColor = System.Drawing.Color.White;
            this.CharacerGeneratorLabel.Location = new System.Drawing.Point(188, 184);
            this.CharacerGeneratorLabel.Name = "CharacerGeneratorLabel";
            this.CharacerGeneratorLabel.Size = new System.Drawing.Size(436, 45);
            this.CharacerGeneratorLabel.TabIndex = 1;
            this.CharacerGeneratorLabel.Text = "Character Generator";
            this.CharacerGeneratorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.CharacerGeneratorLabel);
            this.Controls.Add(this.MSHLabel);
            this.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MSHLabel;
        private System.Windows.Forms.Timer SplashFormTimer;
        private System.Windows.Forms.Label CharacerGeneratorLabel;
    }
}