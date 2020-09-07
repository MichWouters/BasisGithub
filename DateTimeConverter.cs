using System;

namespace BasisGithub
{
    public class DateTimeConverter
    {
        private DateTime baseUnixDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public DateTime CalculateTimeOfArrival(int duration, DateTime dateTime, TimeInterval timeInterval)
        {
            DateTime result;

            switch (timeInterval)
            {
                case TimeInterval.Seconds:
                    result = dateTime.AddSeconds(duration);
                    break;
                case TimeInterval.Minutes:
                    result = dateTime.AddMinutes(duration);
                    break;
                case TimeInterval.Hours:
                    result = dateTime.AddHours(duration);
                    break;
                default:
                    result = DateTime.Now;
                    break;
            }

            return result;
        }

        public DateTime ConvertUnixTimeToGMTDateTime(int timestamp)
        {
            DateTime result = baseUnixDateTime.AddSeconds(timestamp);
            return result;
        }

        public int ConvertGMTDateTimeToDateUnixTime(DateTime date)
        {
            TimeSpan timeSpan = date - baseUnixDateTime;
            return (int)timeSpan.TotalSeconds;
        }

        public string GetTimeOfDay()
        {
            var currentTime = DateTime.Now.TimeOfDay.Hours;

            if (currentTime >= 0 && currentTime <= 11)
                return "morning";
            else if (currentTime <= 13)
                return "day";
            else if (currentTime <= 18)
                return "afternoon";
            else if (currentTime <= 22)
                return "evening";
            else
                return "night";
        }

        public string SecondsToHoursAndMinutes(int seconds)
        {
            int totalMinutes = seconds / 60;

            int hours = totalMinutes / 60;
            int minutes = totalMinutes % 60;

            if (hours > 0)
            {
                return $"{hours} hours and {minutes} minutes";
            }
            else
            {
                return $"{minutes} minutes";
            }
        }

        public string MinutesToHoursAndMinutes(int minutes)
        {
            int hours = minutes / 60;
            int remainingMinutes = minutes % 60;

            if (hours > 0)
            {
                return $"{hours} hours and {remainingMinutes} minutes";
            }
            else
            {
                return $"{remainingMinutes} minutes";
            }
        }
    }
}