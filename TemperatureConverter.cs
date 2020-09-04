namespace BasisGithub
{
    public class TemperatureConverter
    {
        public double KelvinToCelsius(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert - 273.15;
            return Math.Round(converted, precision);
        }

        public double CelsiusToKelvin(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert + 273.15;
            return Math.Round(converted, precision);
        }
    }
}