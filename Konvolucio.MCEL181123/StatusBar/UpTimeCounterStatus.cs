﻿

namespace Konvolucio.MCEL181123.Calib.StatusBar
{
    using System;
    using System.Windows.Forms;
    using Properties;

    class UpTimeCounterStatus : ToolStripStatusLabel
    { 
        public UpTimeCounterStatus()
        {
            BorderSides = ToolStripStatusLabelBorderSides.Left;
            BorderStyle = Border3DStyle.Etched;
            Size = new System.Drawing.Size(58, 19);
            Text = AppConstants.ValueNotAvailable2;


            TimerService.Instance.Tick += (s, e) =>
            {
                if(DevIoSrv.Instance.IsOpen && Settings.Default.UpTimeCounterPeriodicUpdate)
                    Text = "UpTime Counter: " + DevIoSrv.Instance.ReadUpTime(0);
            };
        }
    }
}
