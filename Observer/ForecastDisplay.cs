using System;

namespace Observer
{
    public class ForecastDisplay: IObserver, IDisplayElement
    {
        protected ISubject WeatherDatasuSubject;
        
        protected float Temperature;
        protected float Humidity;
        protected float Pressure;

        public ForecastDisplay(ISubject weatherDatasuSubject)
        {
            WeatherDatasuSubject = weatherDatasuSubject;
            weatherDatasuSubject.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            Display();
        }

        public void Display()
        {
            var temperatureMessage = (Temperature > 25) ? "warm" : (Temperature > 18) ? "mild" : "cool";
            var humidityMessage = (Humidity > 80) ? "rainy" : (Humidity>50)?"fine":"very dry";

            Console.WriteLine("Forecast: {0} and {1} weather",temperatureMessage, humidityMessage);
        }
    }
}