using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konvolucio.MCEL181123.View
{
    public partial class FunctionsNode : UserControl, IUIPanelProperties
    {
        public FunctionsNode()
        {
            InitializeComponent();
            this.Name = "FunctionsNode";
            textBoxSetVolt.Text = 3.5.ToString();
            textBoxSetCurrent.Text = 99.ToString();
           
        }

        public void UiUpdate()
        {
            comboBox1.Text = DevIoSrv.Instance.GetCurrRange(0);
            ButtonRead_Click(null, null);
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
           textBox1.Text = DevIoSrv.Instance.MeasVolt(0).ToString();
           textBox2.Text = DevIoSrv.Instance.MeasCurr(0).ToString();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevIoSrv.Instance.SetCurrRange(0, comboBox1.SelectedItem.ToString());
        }

        private void ButtonSet_Click(object sender, EventArgs e)
        {
            DevIoSrv.Instance.SetCurrent(0, double.Parse(textBoxSetCurrent.Text));
            DevIoSrv.Instance.SetVolt(0, double.Parse(textBoxSetVolt.Text));
        }
    }
}
