namespace Konvolucio.MCEL181123.Calib.View
{
    partial class SettingsNode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxOpenAfterStart = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxUpTimeCounterPeriodicUpdateCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxOpenAfterStart
            // 
            this.checkBoxOpenAfterStart.AutoSize = true;
            this.checkBoxOpenAfterStart.Location = new System.Drawing.Point(5, 28);
            this.checkBoxOpenAfterStart.Name = "checkBoxOpenAfterStart";
            this.checkBoxOpenAfterStart.Size = new System.Drawing.Size(250, 17);
            this.checkBoxOpenAfterStart.TabIndex = 3;
            this.checkBoxOpenAfterStart.Text = "Alkalmazás inditása után automatikus protnyitás";
            this.checkBoxOpenAfterStart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Teszt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBoxUpTimeCounterPeriodicUpdateCheck
            // 
            this.checkBoxUpTimeCounterPeriodicUpdateCheck.AutoSize = true;
            this.checkBoxUpTimeCounterPeriodicUpdateCheck.Location = new System.Drawing.Point(5, 51);
            this.checkBoxUpTimeCounterPeriodicUpdateCheck.Name = "checkBoxUpTimeCounterPeriodicUpdateCheck";
            this.checkBoxUpTimeCounterPeriodicUpdateCheck.Size = new System.Drawing.Size(199, 17);
            this.checkBoxUpTimeCounterPeriodicUpdateCheck.TabIndex = 9;
            this.checkBoxUpTimeCounterPeriodicUpdateCheck.Text = "UpTime Counter periodikus frissítése";
            this.checkBoxUpTimeCounterPeriodicUpdateCheck.UseVisualStyleBackColor = true;
            this.checkBoxUpTimeCounterPeriodicUpdateCheck.CheckedChanged += new System.EventHandler(this.checkBoxUpTimeCounterPeriodicUpdateCheck_CheckedChanged);
            // 
            // SettingsNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxUpTimeCounterPeriodicUpdateCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxOpenAfterStart);
            this.Name = "SettingsNode";
            this.Size = new System.Drawing.Size(705, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxOpenAfterStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxUpTimeCounterPeriodicUpdateCheck;
    }
}
