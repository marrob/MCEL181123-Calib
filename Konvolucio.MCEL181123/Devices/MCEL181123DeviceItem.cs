﻿
namespace Konvolucio.MCEL181123.Devices
{
    using System;
    using System.ComponentModel;
    using Common;
    using System.Collections;
    using CanDatabase;
    using System.Linq;

    public class MCEL181123DeviceItem : IDevice, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public byte Address { get; private set; }

        public byte Rack { get { return (byte)(Address & 0xF0); } }
        public byte Modul { get { return (byte)(Address & 0x0F); } }

        public float VMon { get; private set; }
        public float CMon { get; private set; }

        public bool CcMode { get; private set; }
        public bool CvMOde { get; private set; }

        public Int64 UpTime { get; private set; }

        public DateTime LastRx { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MCEL181123DeviceItem( )
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="deviceAddress"></param>
        /// <param name="msgId"></param>
        /// <param name="data"></param>
        public MCEL181123DeviceItem(byte deviceAddress, byte msgId, byte[] data)
        {
            Address = deviceAddress;
            Update(msgId, data); 
        }

        public void Update(byte msgId, byte[] data)
        {
            //LastRx = DateTime.Now;

            //var signal = CanDb.Instance.GetSignal(CanDb.Instance.Nodes.FirstOrDefault(n=>n.Name == NodeCollection.NODE_MCEL), msgId);
            
            //if (signal.Name == SignalCollection.)
            //if (CanDb.Instance.Messages.FirstOrDefault(n => n.Name == MessageCollection.MSG_MCEL_LIVE).Id == msgId)
            //{
            //    OnProppertyChanged(Tools.GetPropertyName(() => UpTime));
            //}

            //switch (msgId)
            //{
            //    case MSGTYPE_MCEL_LIVE:
            //        {

            //           // CanDb.Instance.Messages.FirstOrDefault(n=>n.Name == "").

            //            UpTime = BitConverter.ToInt64(data, 0);
                        
            //            break;
            //        }

            //    case MSGTPYE_MCEL_MONITOR:
            //        {   
            //            VMon = BitConverter.ToSingle(data, 0);
            //            OnProppertyChanged(Tools.GetPropertyName(() => VMon));
            //            CMon = BitConverter.ToSingle(data, 4);
            //            OnProppertyChanged(Tools.GetPropertyName(() => CMon));
            //            break;
            //        }

            //    default:
            //        {
            //            break;
            //        };

               
           // }
        }

        /// <summary>
        /// Tulajdonság változott
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnProppertyChanged(string propertyName)
        {
              PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
