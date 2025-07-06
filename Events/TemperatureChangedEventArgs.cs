using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class TemperatureChangedEventArgs : EventArgs
    {
        public double Temperature { get; }

        public string Location { get; }

        public TemperatureChangedEventArgs(double Temperature, string Location)
        {
            this.Temperature = Temperature; 
            this.Location = Location;
        }
    }
}
