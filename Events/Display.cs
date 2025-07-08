using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Display
    {
        public void subscriber (Thermometer thermometer)
        {
            thermometer.TemperatureChanged += OnTempraturChanged;
        }

        public void OnTempraturChanged(object sender, TemperatureChangedEventArgs  e)
        {
            Console.WriteLine($"[Display] Temperature at {e.Location} is now {e.Temperature}°C");
        }
    }
}
