using System.Collections.Generic;

namespace WeatherStation.ConsoleApp
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            this.observers.ForEach(o => o.Update(this.temperature, this.humidity, this.pressure));
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }
    }
}