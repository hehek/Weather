using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeatherMod
{
    public class WeatherViewModel: ViewModelBase
    {
     
        private Weather _weather;
        private Params _params;
    

        public WeatherViewModel()
        {
            _weather = new Weather();
            _params = new Params();
        }

        private List<Params> Params { get; set; }

   

        private string _region;
        public string Reg
        {
            get { return _region; }
            set
            {
                _region = value;
                OnPropertyChanged();
            }
        }

        private WeatherForecast _currentWeather = new WeatherForecast();
        public  WeatherForecast CurrentWeather
        {
            get { return _currentWeather; }
            set
            {
                _currentWeather = value;
                OnPropertyChanged();
            }
        }

        OpenWeatherMapService o = new OpenWeatherMapService(1);
        public async Task GetWeather()
        {
            try
            {
                var weather = await o.GetForecastAsync(Reg, 3);
                CurrentWeather = weather.First();


            }

            catch (Exception ex)
            {
                throw new Exception("Something get wrong");
            }
        }



        public string Temp
        {
            get
            {
                return _weather.Temperature.ToString();
            }
            set
            {
                _weather.Temperature = Convert.ToDouble(value);
                OnPropertyChanged("Temp");
            }
        }

        public string Pressure
        {
            get
            {
                return _weather.Pressure.ToString();
            }
            set
            {
                _weather.Pressure = Convert.ToDouble(value);
                OnPropertyChanged("Pressure");
            }
        }

        public string Humidity
        {
            get
            {
                return _weather.Humidity.ToString();
            }
            set
            {
                _weather.Humidity = Convert.ToDouble(value);
                OnPropertyChanged("Humidity");
            }
        }



    }

    }

