


namespace Konvolucio.MCEL181123.Calib.View
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Controls;
    using Properties;

    public partial class CurrentMeasNode : UserControl, IUIPanelProperties
    {
        bool UserInFocus = false;
        string CurrentLimit = "";

        public CurrentMeasNode()
        {
            InitializeComponent();
            this.Name = "CurrentMeasNode";

            TimerService.Instance.Tick += (s, e) =>
            {
                if (UserInFocus && DevIoSrv.Instance.IsOpen)
                {
                    DevIoSrv.Instance.SetTriggerCurrent(0);
                    if(CurrentLimit == "100mA")
                       textBox1.Text = DevIoSrv.Instance.MeasCurr(0).ToString("000.00") + " mA";
                    else if (CurrentLimit == "50uA")
                        textBox1.Text = DevIoSrv.Instance.MeasCurr(0).ToString("00.000") + " uA";
                }
            };
        }

        private void configItemControl_Send(object sender, EventArgs e)
        {
            var config = (sender as ConfigItemControl);
        }


        public void UserLeave()
        {
            UserInFocus = false;
        }

        public void UserEnter()
        {
            UserInFocus = true;

            CurrentLimit =  DevIoSrv.Instance.GetCurrRange(0);
        }
    }
}
