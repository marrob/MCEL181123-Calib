namespace Konvolucio.MCEL181123.Calib.View
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
    using Controls;
    using Events;

    public partial class FunctionsNode : UserControl, IUIPanelProperties
    {
        public FunctionsNode()
        {
            InitializeComponent();
            this.Name = "FunctionsNode";
            textBoxSetVolt.Text = 3.5.ToString();
            textBoxSetCurrent.Text = 99.ToString();
        }

        public void UserEnter()
        {
            comboBox1.Text = DevIoSrv.Instance.GetCurrRange(0);
            ButtonRead_Click(null, null);
        }

        private void ButtonRead_Click(object sender, EventArgs e)
        {
            textBox1.Text = DevIoSrv.Instance.MeasVolt(0).ToString();
            textBox2.Text = DevIoSrv.Instance.MeasCurr(0).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DevIoSrv.Instance.SetTriggerVolt(0);
            textBox1.Text = DevIoSrv.Instance.MeasVolt(0).ToString();
            System.Threading.Thread.Sleep(500);
            DevIoSrv.Instance.SetTriggerCurrent(0);
            textBox2.Text = DevIoSrv.Instance.MeasCurr(0).ToString();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if(comboBox1.Text == "100mA")
                DevIoSrv.Instance.SetCurrRange(0, DevIoSrv.CurrentRange.Current_100mA);
            else if(comboBox1.Text == "50uA")
                DevIoSrv.Instance.SetCurrRange(0, DevIoSrv.CurrentRange.Current_50uA);

            DevIoSrv.Instance.SetCurrentLimit(0, double.Parse(textBoxSetCurrent.Text));
            DevIoSrv.Instance.SetVolt(0, double.Parse(textBoxSetVolt.Text));

            if (radioButton1.Checked)
                DevIoSrv.Instance.SetSense(0, DevIoSrv.Senese.Remote);

            if (radioButton2.Checked)
                DevIoSrv.Instance.SetSense(0, DevIoSrv.Senese.Local);

            if (radioButton3.Checked)
                DevIoSrv.Instance.OutputOff(0);

            if (radioButton4.Checked)
                DevIoSrv.Instance.OutputOn(0);


            EventAggregator.Instance.Publish(new ConfigsChangedAppEvent());

        }

        public void UserLeave()
        { 

        }
    }
}
