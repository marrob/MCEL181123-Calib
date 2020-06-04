

namespace Konvolucio.MCEL181123.View
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Konvolucio.MCEL181123.Properties;

    public partial class ConnectionNode : UserControl, IUIPanelProperties
    {
        public ConnectionNode()
        {
            InitializeComponent();
            this.Name = "ConnectionNode";
            checkBoxOpenAfterStart.Checked = Settings.Default.OpenAfterStartUp;
        }

        public void UiUpdate()
        {
            if (DevIoSrv.Instance.IsOpen)
            {
                buttonOpen.Text = "Lezárás";
            }

            comboBox1.Items.AddRange(DevIoSrv.GetPortNames());

            if (!string.IsNullOrEmpty(Settings.Default.SeriaPortName))
            {
                comboBox1.Text = Settings.Default.SeriaPortName;
                ButtonOpen_Click(this, null);
            }
        }
    
        private void ButtonOpen_Click(object sender, EventArgs e)
        { 
            if ( !DevIoSrv.Instance.IsOpen )
            {
                DevIoSrv.Instance.Open(comboBox1.Text);
                Settings.Default.SeriaPortName = comboBox1.Text;
                buttonOpen.Text = "Lezárás";

            }
            else
            {
                buttonOpen.Text = "Megnyitás";
                DevIoSrv.Instance.Close();
            }
        }

        private void TextBox1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.SeriaPortName = comboBox1.Text;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxOpenAfterStart_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.OpenAfterStartUp = checkBoxOpenAfterStart.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DevIoSrv.Instance.Test();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(DevIoSrv.GetPortNames());
        }
    }
}
