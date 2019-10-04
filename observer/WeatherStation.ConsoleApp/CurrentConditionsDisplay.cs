using System;

namespace WeatherStation.ConsoleApp
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float hummidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;

            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float hummidity, float pressure)
        {
            this.temperature = temperature;
            this.hummidity = hummidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {this.temperature:F1}F degrees and {this.hummidity:F1}%");
        }
    }
}