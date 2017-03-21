using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Weather
    {
        double temp;
        double humd;
        double pres;

        public double Pressure
        {
            get { return this.pres; }
        }

        public double Humidity
        {
            get { return this.humd; }
        }

        public double Temperature
        {
            get { return this.temp; }
        }

        public Weather(double humd, double pres, double temp)
        {
            this.temp = temp;
            this.pres = pres;
            this.humd = humd;
        }
    }
}
