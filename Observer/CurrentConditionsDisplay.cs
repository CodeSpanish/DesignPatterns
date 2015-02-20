using System;

namespace Observer
{
    public class CurrentConditionsDisplay: IObserver, IDisplayElement
    {
        protected float Temperature;
        protected float Humidity;
        protected ISubject WeatherData;

        public CurrentConditionsDisplay(ISubject weatherDataSubject)
        {
            WeatherData = weatherDataSubject;
            weatherDataSubject.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions:{0}C degrees {1}% humidity",Temperature,Humidity);
        }
    }
}