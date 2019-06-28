using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMod
{
    class Params: IEquatable<Params>, IParams
    {
        public string Temp { get; set; }
        public string Pressure { get; set; }
     
        public string Region { get; set; }
        public int CurrTime { get; set; }


        public double tempOption(double temp)
        {
            switch (Temp)
            {
                case "C": break;
                case "F": temp = (temp * 9 / 5) + 32; break;
            }

            return temp;
        }

        public double pressureOption(double pressure)
        {
            switch (Pressure)
            {
                case "P": break;
                case "mm": pressure = pressure * 101325 / 760; break;
            }

            return pressure;
        }

        public bool Equals(Params other)
        {
            return Region.Equals(other.Region) && Temp.Equals(other.Temp)&& Pressure.Equals(other.Pressure) && CurrTime.Equals(other.CurrTime);
        }

    }
}
