namespace Konvolucio.MCEL181123.Calib.View
{
    partial class ConfigsNode
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
            this.configItemControl6 = new Controls.ConfigItemControl();
            this.configItemControl5 = new Controls.ConfigItemControl();
            this.configItemControl4 = new Controls.ConfigItemControl();
            this.configItemControl3 = new Controls.ConfigItemControl();
            this.configItemControl2 = new Controls.ConfigItemControl();
            this.configItemControl1 = new Controls.ConfigItemControl();
            this.SuspendLayout();
            // 
            // configItemControl6
            // 
            this.configItemControl6.Ampers = "99";
            this.configItemControl6.CurrentLimit = "100mA";
            this.configItemControl6.Label = "Config 6";
            this.configItemControl6.Local = false;
            this.configItemControl6.Location = new System.Drawing.Point(638, 3);
            this.configItemControl6.Name = "configItemControl6";
            this.configItemControl6.Remote = true;
            this.configItemControl6.Size = new System.Drawing.Size(121, 261);
            this.configItemControl6.TabIndex = 5;
            this.configItemControl6.Volts = "5";
            this.configItemControl6.Send += new System.EventHandler(this.configItemControl_Send);
            // 
            // configItemControl5
            // 
            this.configItemControl5.Ampers = "99";
            this.configItemControl5.CurrentLimit = "100mA";
            this.configItemControl5.Label = "Config 5";
            this.configItemControl5.Local = false;
            this.configItemControl5.Location = new System.Drawing.Point(511, 3);
            this.configItemControl5.Name = "configItemControl5";
            this.configItemControl5.Remote = true;
            this.configItemControl5.Size = new System.Drawing.Size(121, 261);
            this.configItemControl5.TabIndex = 4;
            this.configItemControl5.Volts = "4";
            this.configItemControl5.Send += new System.EventHandler(this.configItemControl_Send);
            // 
            // configItemControl4
            // 
            this.configItemControl4.Ampers = "99";
            this.configItemControl4.CurrentLimit = "100mA";
            this.configItemControl4.Label = "Config 4";
            this.configItemControl4.Local = false;
            this.configItemControl4.Location = new System.Drawing.Point(384, 3);
            this.configItemControl4.Name = "configItemControl4";
            this.configItemControl4.Remote = true;
            this.configItemControl4.Size = new System.Drawing.Size(121, 261);
            this.configItemControl4.TabIndex = 3;
            this.configItemControl4.Volts = "3";
            this.configItemControl4.Send += new System.EventHandler(this.configItemControl_Send);
            // 
            // configItemControl3
            // 
            this.configItemControl3.Ampers = "99";
            this.configItemControl3.CurrentLimit = "100mA";
            this.configItemControl3.Label = "Config 3";
            this.configItemControl3.Local = false;
            this.configItemControl3.Location = new System.Drawing.Point(257, 3);
            this.configItemControl3.Name = "configItemControl3";
            this.configItemControl3.Remote = true;
            this.configItemControl3.Size = new System.Drawing.Size(121, 261);
            this.configItemControl3.TabIndex = 2;
            this.configItemControl3.Volts = "2";
            this.configItemControl3.Send += new System.EventHandler(this.configItemControl_Send);
            // 
            // configItemControl2
            // 
            this.configItemControl2.Ampers = "99";
            this.configItemControl2.CurrentLimit = "100mA";
            this.configItemControl2.Label = "Config 2";
            this.configItemControl2.Local = false;
            this.configItemControl2.Location = new System.Drawing.Point(130, 3);
            this.configItemControl2.Name = "configItemControl2";
            this.configItemControl2.Remote = true;
            this.configItemControl2.Size = new System.Drawing.Size(121, 261);
            this.configItemControl2.TabIndex = 1;
            this.configItemControl2.Volts = "1";
            this.configItemControl2.Send += new System.EventHandler(this.configItemControl_Send);
            // 
            // configItemControl1
            // 
            this.configItemControl1.Ampers = "99";
            this.configItemControl1.CurrentLimit = "100mA";
            this.configItemControl1.Label = "Config 1";
            this.configItemControl1.Local = false;
            this.configItemControl1.Location = new System.Drawing.Point(3, 3);
            this.configItemControl1.Name = "configItemControl1";
            this.configItemControl1.Remote = true;
            this.configItemControl1.Size = new System.Drawing.Size(121, 261);
            this.configItemControl1.TabIndex = 0;
            this.configItemControl1.Volts = "0.1";
            this.configItemControl1.Send += new System.EventHandler(this.configItemControl_Send);
            this.configItemControl1.Load += new System.EventHandler(this.configItemControl1_Load);
            // 
            // ConfigsNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.configItemControl6);
            this.Controls.Add(this.configItemControl5);
            this.Controls.Add(this.configItemControl4);
            this.Controls.Add(this.configItemControl3);
            this.Controls.Add(this.configItemControl2);
            this.Controls.Add(this.configItemControl1);
            this.Name = "ConfigsNode";
            this.Size = new System.Drawing.Size(762, 279);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ConfigItemControl configItemControl1;
        private Controls.ConfigItemControl configItemControl2;
        private Controls.ConfigItemControl configItemControl3;
        private Controls.ConfigItemControl configItemControl4;
        private Controls.ConfigItemControl configItemControl5;
        private Controls.ConfigItemControl configItemControl6;
    }
}
