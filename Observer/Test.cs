namespace Observer
{
    public static class Test
    {
        public static void Run()
        {
            var weatherData=new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);
            var statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(30,80,50);
            weatherData.SetMeasurements(15,80,0);
            weatherData.SetMeasurements(25,50,0);

        } 
    }
}