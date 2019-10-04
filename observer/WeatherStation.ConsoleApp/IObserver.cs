namespace WeatherStation.ConsoleApp
{
    public interface IObserver
    {
        void Update(float temperature, float hummidity, float pressure);
    }
}