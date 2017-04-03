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
            this.CharacterGeneratorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MSHLabel
            // 
            this.MSHLabel.AutoSize = true;
            this.MSHLabel.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSHLabel.ForeColor = System.Drawing.Color.White;
            this.MSHLabel.Location = new System.Drawing.Point(133, 117);
            this.MSHLabel.Name = "MSHLabel";
            this.MSHLabel.Size = new System.Drawing.Size(559, 56);
            this.MSHLabel.TabIndex = 0;
            this.MSHLabel.Text = "Marvel Super Heroes";
            // 
            // SplashFormTimer
            // 
            this.SplashFormTimer.Enabled = true;
            this.SplashFormTimer.Interval = 3000;
            this.SplashFormTimer.Tick += new System.EventHandler(this.SplashFormTimer_Tick);
            // 
            // CharacterGeneratorLabel
            // 
            this.CharacterGeneratorLabel.AutoSize = true;
            this.CharacterGeneratorLabel.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterGeneratorLabel.ForeColor = System.Drawing.Color.White;
            this.CharacterGeneratorLabel.Location = new System.Drawing.Point(230, 183);
            this.CharacterGeneratorLabel.Name = "CharacterGeneratorLabel";
            this.CharacterGeneratorLabel.Size = new System.Drawing.Size(362, 38);
            this.CharacterGeneratorLabel.TabIndex = 1;
            this.CharacterGeneratorLabel.Text = "Character Generator";
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.CharacterGeneratorLabel);
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
        private System.Windows.Forms.Label CharacterGeneratorLabel;
    }
}