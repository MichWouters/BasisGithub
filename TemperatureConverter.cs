using System;

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

        public double KelvinToFahrenheit(double valueToConvert, int precision = 2)
        {
            double converted = 1.8 * (valueToConvert - 273.15) + 32;
            return Math.Round(converted, precision);
        }

        public double CelsiusToFahrenheit(double valueToConvert, int precision = 2)
        {
            double converted = (valueToConvert * 1.8) + 32;
            return Math.Round(converted, precision);
        }

        public double FahrenheitToKelvin(double valueToConvert, int precision = 2)
        {
            double converted = (5f / 9f) * (valueToConvert - 32) + 273.15;
            return Math.Round(converted, precision);
        }

        public double FahrenheitToCelsius(double valueToConvert, int precision = 2)
        {
            double converted = (valueToConvert - 32) / 1.8;
            return Math.Round(converted, precision);
        }
    }
}