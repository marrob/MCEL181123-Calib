﻿

namespace Konvolucio.MCEL181123.Calib.StatusBar
{
    using System;
    using System.Windows.Forms;
    using Properties;
    using Events;
    class CurrentRangeStatusBar: ToolStripStatusLabel
    { 
        public CurrentRangeStatusBar()
        {
            BorderSides = ToolStripStatusLabelBorderSides.Left;
            BorderStyle = Border3DStyle.Etched;
            Size = new System.Drawing.Size(58, 19);
            Text = "Current Range: " + AppConstants.ValueNotAvailable2;

            EventAggregator.Instance.Subscribe((Action<ConfigsChangedAppEvent>)(e =>
            {
                if (DevIoSrv.Instance.GetLastCurrentRange == DevIoSrv.CurrentRange.Current_100mA)
                    Text = "Current Range: 100mA";
                else if (DevIoSrv.Instance.GetLastCurrentRange == DevIoSrv.CurrentRange.Current_50uA)
                    Text = "Current Range: 50uA";
            }));
        }
    }
}
