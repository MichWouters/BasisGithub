using System;

namespace BasisGithub
{
    public class DistanceConverter
    {
        public double MilesToKilometers(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert * 1.60934;
            converted = Math.Round(converted, precision);

            Console.WriteLine($"Result: {converted}");
            return Math.Round(converted, precision);
        }

        public double KilometersToMiles(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert * 0.62137;

            Console.WriteLine($"Result: {converted}");
            return Math.Round(converted, precision);
        }

        public double MetersToKilometers(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert / 1000;
            converted = Math.Round(converted, precision);

            Console.WriteLine($"Result: {converted}");
            return Math.Round(converted, precision);
        }

        public double KilometersToMeters(double valueToConvert, int precision = 2)
        {
            double converted = valueToConvert * 1000;

            Console.WriteLine($"Result: {converted}");
            return Math.Round(converted, precision);
        }
    }
}