using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konvolucio.MCEL181123.Calib.Controls
{
  

    public partial class ConfigItemControl : UserControl
    { 
        public event EventHandler Send;
        

        public string CurrentLimit
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }

        public string Label
        {
            set { groupBox1.Text = value;  }
            get { return groupBox1.Text; }
        }

        public string Volts
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }

        public string Ampers
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }

        public bool Remote {
            set { radioButton1.Checked = value; }
            get { return radioButton1.Checked; }
        }
        public bool Local
        {
            set { radioButton2.Checked = value; }
            get { return radioButton2.Checked; }
        }
       

        public ConfigItemControl()
        {
            InitializeComponent();

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (Send != null)
                Send(this, EventArgs.Empty);


            comboBox1_SelectedIndexChanged(this, EventArgs.Empty);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "100mA")
            {
                labelCurrentLimit.Text = "Current Limit (mA)";
            }
            else if(comboBox1.Text == "50uA")
            {
                labelCurrentLimit.Text = "Current Limit (uA)";
            }


        }
    }
}
