﻿namespace Konvolucio.MCEL181123.Calib.View
{
    using System;
    using System.Linq;
    using System.Net.NetworkInformation;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Controls;
    using Properties;

    public partial class VoltageMeasNode : UserControl, IUIPanelProperties
    {

        bool UserInFocus = false;

        public VoltageMeasNode()
        {
            InitializeComponent();
            this.Name = "VoltageMeasNode";

            TimerService.Instance.Tick += (s, e) =>
            {
                if (UserInFocus && DevIoSrv.Instance.IsOpen)
                {
                    DevIoSrv.Instance.SetTriggerVolt(0);
                    textBox1.Text = DevIoSrv.Instance.MeasVolt(0).ToString("0.0000") + " V";
                }
            };

        }

        private void configItemControl_Send(object sender, EventArgs e)
        {
            var config = (sender as ConfigItemControl);
        }



         private void buttonStartStop_Click(object sender, EventArgs e)
        {

        }

        public void UserLeave()
        {
            UserInFocus = false;
        }

        public void UserEnter()
        {
            UserInFocus = true;
        }
    }
}
