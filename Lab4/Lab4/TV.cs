using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Lab4
{
    internal class TV
    {
        private int _channel;
        private bool _isOn;

        public void TurnOn()
        {
            if (_isOn) Console.WriteLine("it is already On");
            else _isOn = true;
        }
        public void TurnOff()
        {
            if(!_isOn) Console.WriteLine("it is already Off");
            else _isOn = false;
        }
        public void ChangeChannel(int channel)
        {
            _channel = channel;
        }
        public void PrintStatus()
        {
            Console.WriteLine($"tv is { (_isOn ? "On" : "Off")} and Channel is {_channel} ");//bele olmali deyile prosta tasklar choxdu.prioritet keyfiyyet yox kemiyyetdi
        }
    }
}
