using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Web;


namespace AVweb.Models
{
    public class Forecast
    {
        //Esto lo habia puesto en una variable de entorno pero no van a poder ejecutarlo desde su PC
        private readonly string appid = "fa9c1ef1e9ad5a9411bbae835883ab6c";

        [Display(Name ="País")]
        public string Country { get; set; }

        [Display(Name = "Ciudad")]
        public string City { get; set; }

        public List<string> main { get; set; }
        public double Temp { get; set; }
        public int Humidity { get; set; }
        public double Wind { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Weather { get; set; }

        private double farenheit;

        public double Farenheit
        {
            get { return ((9.0/5.0) * farenheit) + 32; }
            set { farenheit = value; }
        }


        public void GetWeatherData(string city, string country)
        {
            
            using(var client = new WebClient())
            {
                string url = "";
                if (city == null)
                {
                    url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=es", "Buenos Aires", this.appid);//Buenos aires por defecto
                }
                else
                {
                    url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric&lang=es", city, this.appid);
                }
                
                var json = client.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherData.RootObject>(json);
                WeatherData.RootObject x = result;

                ServiceRef.Service1Client ws = new ServiceRef.Service1Client();
                
                this.City = ws.GetCity(city);
                this.Country = ws.GetCountry(country);
                this.Temp = ws.GetTemperature(x.main.temp);
                this.Humidity = x.main.humidity;
                this.Wind = ws.GetWind(x.wind.speed);
                this.farenheit = ws.GetFarenheit(x.main.temp);
                this.Name = ws.GetName(x.name);
                this.Description = ws.GetDescription(x.weather[0].description);

            }
            
        }
    }
}
