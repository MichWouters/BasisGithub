using System;

namespace BasisGithub
{
    public class DistanceHelper
    {
        public double MilesToKilometers(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert * 1.61;
            converted = Math.Round(converted, precision);

            return converted;
        }

        public double KilometersToMiles(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert * 0.62;
            converted = Math.Round(converted, precision);

            return converted;
        }

        public double MetersToKilometers(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert / 1000;
            converted = Math.Round(converted, precision);

            return converted;
        }

        public double KilometersToMeters(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert * 1000;
            converted = Math.Round(converted, precision);

            return converted;
        }
    }
}