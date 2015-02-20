using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class StatisticsDisplay: IObserver, IDisplayElement
    {
        protected ISubject WeatherDataSubject;
        
        protected List<float> Temperature;
        protected List<float> Humidity;
        protected List<float> Pressure;
        
        public StatisticsDisplay(ISubject weatherDatasSubject)
        {
            Temperature=new List<float>();
            Humidity=new List<float>();
            Pressure=new List<float>();

            WeatherDataSubject = weatherDatasSubject;
            weatherDatasSubject.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            Temperature.Add(temperature);
            Humidity.Add(humidity);
            Pressure.Add(pressure);
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Avg/Max/Min temperature: {0}C / {1}C / {2}C",Temperature.Average(),Temperature.Max(),Temperature.Min());
        }
    }
}
