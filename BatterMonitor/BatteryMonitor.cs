using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatterMonitor
{
    public class BatteryMonitor
    {
        public delegate void BatteryLowEventHandler(object sender, EventArgs e);
        public event BatteryLowEventHandler? BatteryLow;

        private int _batteryLevel;

        public BatteryMonitor(int initialLevel)
        {
            _batteryLevel = initialLevel;
        }

        public int BatteryLevel
        {
            get => _batteryLevel;
            set
            {
                _batteryLevel = value;
                if (_batteryLevel < 20)
                {
                    OnBatteryLow(EventArgs.Empty); 
                }
            }
        }

        protected virtual void OnBatteryLow(EventArgs e)
        {
            BatteryLow?.Invoke(this, e);
        }
    }
}
