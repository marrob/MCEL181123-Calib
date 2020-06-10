

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

    public partial class ConfigsNode : UserControl
    {
        public ConfigsNode()
        {
            InitializeComponent();
            this.Name = "ConfigsNode";
        }

        private void configItemControl_Send(object sender, EventArgs e)
        {
            var config = (sender as ConfigItemControl);

            try
            {
                DevIoSrv.Instance.SetVolt(0, double.Parse(config.Volts));
                DevIoSrv.Instance.SetCurrentLimit(0, double.Parse(config.Ampers));

                if(config.CurrentLimit == "100mA")  
                    DevIoSrv.Instance.SetCurrRange(0, DevIoSrv.CurrentRange.Current_100mA);
                else if(config.CurrentLimit == "50uA")
                    DevIoSrv.Instance.SetCurrRange(0, DevIoSrv.CurrentRange.Current_50uA);

                if (config.Remote)
                    DevIoSrv.Instance.SetSense(0, DevIoSrv.Senese.Remote);
                if (config.Local)
                    DevIoSrv.Instance.SetSense(0, DevIoSrv.Senese.Local);

                DevIoSrv.Instance.OutputOn(0);

                EventAggregator.Instance.Publish(new ConfigsChangedAppEvent());

            }
            catch (Exception ex)
            {
                DevIoSrv.Instance.Trace(ex.Message);
            }
        }

        private void configItemControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
