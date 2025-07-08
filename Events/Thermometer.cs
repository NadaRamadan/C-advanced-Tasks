using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Thermometer
    {
        private double _currentTempratur;
        public string Location;
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        public Thermometer(string location)
        {
            Location = location;
        }

        public void setTemprature(double newTemprature)
        {
            if(_currentTempratur != newTemprature)
            {
                _currentTempratur = newTemprature;
                onTempratureChanged(new TemperatureChangedEventArgs(newTemprature, Location));
            }

        }
        protected virtual void onTempratureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }

    }
}
