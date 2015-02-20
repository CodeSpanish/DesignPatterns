using System.Collections.Generic;

namespace Observer
{
    public class WeatherData: ISubject
    {
        protected List<IObserver> Observers;
        protected float Temperature;
        protected float Humidity;
        protected float Pressure;

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObservers(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {
                observer.Update(temperature:Temperature, humidity:Humidity,pressure:Pressure);
            };
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            MeasurementsChanged();
        }
    }
}