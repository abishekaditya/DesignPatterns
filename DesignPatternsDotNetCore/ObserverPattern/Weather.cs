namespace ObserverPattern
{
    class Weather
    {
        public double Pressure { get; }

        public double Humidity { get; }

        public double Temperature { get; }

        public Weather(double humd, double pres, double temp)
        {
            Temperature = temp;
            Pressure = pres;
            Humidity = humd;
        }
    }
}
