using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMod
{
    public interface IParams
    {
        double tempOption(double temp);
        double pressureOption(double pressure);
    }
}
