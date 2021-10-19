using System;
using System.Collections.Generic;
using System.Text;

namespace modul6opg3.Shared
{
    public class WeatherForecast
    {
        private string[] array = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary => chooseSummary(array, TemperatureC);

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string chooseSummary(string[] array, int temp)
        { 
            
            int output = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (temp < -20 + (7.5 * (i + 1)) && temp > -27.5 + (7.5 * (i + 1)))
                {
                    output = i;
                }
            }
            return array[output];
        }
    }
}
