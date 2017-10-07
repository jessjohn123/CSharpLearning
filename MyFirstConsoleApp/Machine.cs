using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyFirstConsoleApp
{
    public delegate void TempChanged(double prev, double current);
    class Machine
    {
        private TempChanged tempChanged;
        private double _currentTemperature = 36;
        public double CurrentTemp
        {
            get
            {
                return _currentTemperature;
            }
            set
            {
                if(_currentTemperature != value)
                {
                    var prev = _currentTemperature;
                    _currentTemperature = value;
                    OnTempChanged(prev, value);
                }
            }
        }

        public void TurnOn()
        {
            while(CurrentTemp < 100)
            {
                Thread.Sleep(1000);
                CurrentTemp++;
            }
        }

        public void RegisterTempWatcher(TempChanged c)
        {
            tempChanged += c;
        }

        private void OnTempChanged(double prev, double curr)
        {
            // No registered observers
            if(tempChanged != null)
            {
                tempChanged(prev, curr);
            }
           
        }
    }
}
