namespace COMP1004_W2017_Lesson6
{
    partial class PowersForm
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
            this.PowerListLabel = new System.Windows.Forms.Label();
            this.PowerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PowerListLabel
            // 
            this.PowerListLabel.AutoSize = true;
            this.PowerListLabel.Location = new System.Drawing.Point(17, 21);
            this.PowerListLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PowerListLabel.Name = "PowerListLabel";
            this.PowerListLabel.Size = new System.Drawing.Size(207, 46);
            this.PowerListLabel.TabIndex = 0;
            this.PowerListLabel.Text = "Power List";
            // 
            // PowerListBox
            // 
            this.PowerListBox.FormattingEnabled = true;
            this.PowerListBox.ItemHeight = 46;
            this.PowerListBox.Items.AddRange(new object[] {
            "Telepathy",
            "Body Armour",
            "Flight",
            "Telekinesis",
            "Electrical Bolt",
            "Fire Ball",
            "Combat Senses",
            "Radiation Resistance"});
            this.PowerListBox.Location = new System.Drawing.Point(25, 87);
            this.PowerListBox.MultiColumn = true;
            this.PowerListBox.Name = "PowerListBox";
            this.PowerListBox.Size = new System.Drawing.Size(759, 372);
            this.PowerListBox.TabIndex = 1;
            // 
            // PowersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 563);
            this.Controls.Add(this.PowerListBox);
            this.Controls.Add(this.PowerListLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "PowersForm";
            this.Text = "PowersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PowerListLabel;
        private System.Windows.Forms.ListBox PowerListBox;
    }
}