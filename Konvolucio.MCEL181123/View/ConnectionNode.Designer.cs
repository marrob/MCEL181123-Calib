namespace Konvolucio.MCEL181123.View
{
    partial class ConnectionNode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionNode));
            this.buttonOpen = new System.Windows.Forms.Button();
            this.checkBoxOpenAfterStart = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(133, 124);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(82, 21);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Megnyitás";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // checkBoxOpenAfterStart
            // 
            this.checkBoxOpenAfterStart.AutoSize = true;
            this.checkBoxOpenAfterStart.Location = new System.Drawing.Point(6, 151);
            this.checkBoxOpenAfterStart.Name = "checkBoxOpenAfterStart";
            this.checkBoxOpenAfterStart.Size = new System.Drawing.Size(250, 17);
            this.checkBoxOpenAfterStart.TabIndex = 3;
            this.checkBoxOpenAfterStart.Text = "Alkalmazás inditása után automatikus protnyitás";
            this.checkBoxOpenAfterStart.UseVisualStyleBackColor = true;
            this.checkBoxOpenAfterStart.CheckedChanged += new System.EventHandler(this.CheckBoxOpenAfterStart_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(705, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "KAPCSOLAT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 78);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 21);
            this.button1.TabIndex = 8;
            this.button1.Text = "Teszt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectionNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxOpenAfterStart);
            this.Controls.Add(this.buttonOpen);
            this.Name = "ConnectionNode";
            this.Size = new System.Drawing.Size(705, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.CheckBox checkBoxOpenAfterStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}
