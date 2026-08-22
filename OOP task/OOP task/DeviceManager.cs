using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task
{
    internal class DeviceManager
    {
        public void StartDevice(Device device)
        {
            device.TurnOn();
        }
    }
}
