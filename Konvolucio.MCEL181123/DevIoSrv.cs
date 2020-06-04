

namespace Konvolucio.MCEL181123
{ 
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO.Ports;
    using System.Globalization;

    public class DevIoSrv
    {

        public static DevIoSrv Instance { get { return _instance; } }

        private static readonly DevIoSrv _instance = new DevIoSrv();

        public Queue<string> TraceQueue = new Queue<string>();
        public SerialPort _sp;
        public bool IsOpen
        {
            get
            {
                if (_sp == null)
                    return false;
                else
                    return _sp.IsOpen;
            }
        }

        public static string[] GetPortNames()
        {
            // Get a list of serial port names.
            return (SerialPort.GetPortNames());
        }

        public DevIoSrv()
        {

        }

        public void Open(string port)
        {

            try
            {
                _sp = new SerialPort(port);
                _sp.ReadTimeout = 1000;
                _sp.NewLine = "\n";
                _sp.Open();
                Trace("State: " + port + " Opened");
            }
            catch (Exception ex)
            {
                Trace("State: " + port + " Opened-Exception:" + ex.Message);
            }
        }

        public void Test()
        {
            if (_sp == null || !_sp.IsOpen)
            {
                Trace("IO ERROR: port is closed.");
            }

            try
            {
                var resp = WriteRead("*OPC?");
                if (resp == null || resp != "*OPC")
                    Trace("Test Failed");
            }
            catch (Exception ex)
            {
                Trace("IO-ERROR:" + ex.Message);
            }
        }

        string WriteRead(string str)
        {
            if (_sp == null || !_sp.IsOpen)
            {
                Trace("IO ERROR: port is closed " + str);
                return null;
            }
            try
            {
                Trace("Tx: " + str);
                _sp.WriteLine(str);
               // IoLog.Instance.WirteLine(str);
                str = _sp.ReadLine();
               // IoLog.Instance.WirteLine(str);
                Trace("Rx: " + str);
            }
            catch (Exception ex)
            {
                Trace("IO-ERROR:" + ex.Message);
            }
            return str;
        }

        public double MeasVolt(byte node)
        {
            double retval = double.NaN;
            var resp = WriteRead("#" + node.ToString("X2") + " " + "MEAS:VOLT?");
            if (resp == null)
                return double.NaN;
            else if (double.TryParse(resp, NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out retval))
                return retval;
            else
                return double.NaN;
        }

        public double MeasCurr(byte node)
        {
            double retval = double.NaN;
            var resp = WriteRead("#" + node.ToString("X2") + " " + "MEAS:CURR?");
            if (resp == null)
                return double.NaN;
            else if (double.TryParse(resp, NumberStyles.Float, CultureInfo.GetCultureInfo("en-US"), out retval))
                return retval;
            else
                return double.NaN;
        }

        public string GetCurrRange(byte node)
        {
            if (_sp == null || !_sp.IsOpen)
                return "ERROR port is Closed";

            try
            {
                var resp = int.Parse(WriteRead("#" + node.ToString("X2") + " " + "CURR:RNG?"));
                if (resp == 0)
                {
                    return "100mA";
                }
                if (resp == 1)
                {
                    return "50uA";
                }
                else
                {
                    return "Unknown";
                }
            }
            catch(Exception ex)
            {
                Trace("IO-ERROR:" + ex.Message);
            }
            return "na";
        }

        public void SetCurrRange(byte node, string range)
        {
            if (_sp == null || !_sp.IsOpen)
                return;

            int rngid = 0;
            if (range == "100mA")
            {
                rngid = 0;
            }
            else if (range == "50uA")
            {
                rngid = 1;
            }
            else
            {
                throw new ArgumentException("50uA vagy 100mA lehet", "Current Range");
            }

            var resp = WriteRead("#" + node.ToString("X2") + " " + "SET:RNG" + " " + rngid.ToString());
        }

        public void SetVolt(byte node, double volt)
        {
            WriteRead("#" + node.ToString("X2") + " " + "SET:VOLT" + "  " + volt.ToString());
        }

        public void SetCurrent(byte node, double current)
        {
            WriteRead("#" + node.ToString("X2") + " " + "SET:CURR" + "  " + current.ToString());
        }

        public void Close()
        {
            TraceQueue.Enqueue(DateTime.Now.ToString(AppConstants.GenericTimestampFormat) + " " + "State: " + "Closed");
            _sp.Close();
        }

        void Trace(string msg)
        {
            TraceQueue.Enqueue(DateTime.Now.ToString(AppConstants.GenericTimestampFormat) + " " + msg);
        }
    }
}
