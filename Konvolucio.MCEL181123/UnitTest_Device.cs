using System;

namespace Konvolucio.MCEL181123.Calib
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System;
    using NUnit.Framework;

    public class UnitTest_Device
    {
        [Test]
         public void MeasTest()
        {
            var dev = DevIoSrv.Instance;
            dev.Open("COM10");
            var volt =  dev.MeasVolt(0);
            Assert.AreEqual(0, volt);
            dev.Close();
        }

    }
}
