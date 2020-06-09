

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
    using Properties;

    public partial class SettingsNode : UserControl, IUIPanelProperties
    {
        public SettingsNode()
        {
            InitializeComponent();
            this.Name = "SettingsNode";
            
        }

        public void UserEnter()
        {
            checkBoxOpenAfterStart.Checked = Settings.Default.OpenAfterStartUp;
            checkBoxUpTimeCounterPeriodicUpdateCheck.Checked = Settings.Default.UpTimeCounterPeriodicUpdate;
        }
    


        private void CheckBoxOpenAfterStart_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.OpenAfterStartUp = checkBoxOpenAfterStart.Checked;
            Settings.Default.UpTimeCounterPeriodicUpdate = checkBoxUpTimeCounterPeriodicUpdateCheck.Checked;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DevIoSrv.Instance.Test();
        }

        private void checkBoxUpTimeCounterPeriodicUpdateCheck_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.UpTimeCounterPeriodicUpdate = checkBoxUpTimeCounterPeriodicUpdateCheck.Checked;
        }

        public void UserLeave()
        {

        }
    }
}
